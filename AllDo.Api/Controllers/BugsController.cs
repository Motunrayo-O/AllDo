using AllDo.Domain;
using AllDo.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BugsController : ControllerBase
{
    private readonly IRepository<Bug> repository;

    public BugsController(IRepository<Bug> repository)
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
        return Ok(await repository.GetAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Bug bugToCreate)
    {
        await repository.AddAsync(bugToCreate);

        // return CreatedAtRoute(nameof(GetAll), null, bugToCreate);
        return Ok();
    }
}