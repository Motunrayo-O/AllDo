using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AllDo.Api.Controllers
{
    using System;
    using System.Threading.Tasks;
    using AllDo.Domain;
    using AllDo.Infrastructure.Data.Repositories;
    using Microsoft.AspNetCore.Mvc;

    namespace Api.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class FeaturesController : ControllerBase
        {
            private readonly IRepository<FeatureDto> repository;

            public FeaturesController(IRepository<FeatureDto> repository)
            {
                this.repository = repository;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                return Ok(await repository.AllAsync());
            }

            [HttpGet]
            [Route("{id}")]
            public async Task<IActionResult> GetById(Guid id)
            {
                var result = await repository.GetAsync(id);
                if (result is not null)
                    return Ok(result);

                return NotFound();
            }

            [HttpPost]
            public async Task<IActionResult> Create([FromBody] FeatureDto featureToCreate)
            {
                await repository.AddAsync(featureToCreate);

                return CreatedAtAction(nameof(GetById), new { id = featureToCreate.Id }, featureToCreate);
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(Guid id)
            {
                var result = await repository.DeleteAsync(id);
                if (!result) return BadRequest("Couldn't delete");

                return NoContent();
            }
        }
    }
}