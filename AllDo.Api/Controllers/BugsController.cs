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
        var result = await repository.GetAsync(id);
        if (result is not null)
            return Ok();

        return NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] Bug bugToCreate)
    {
        await repository.AddAsync(bugToCreate);

        return CreatedAtAction(nameof(GetById), new { id = bugToCreate.Id }, bugToCreate);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await repository.DeleteAsync(id);
        if (!result) return BadRequest("Couldn't delete");

        return NoContent();
    }

}