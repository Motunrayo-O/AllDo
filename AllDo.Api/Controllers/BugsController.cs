using AllDo.Domain;
using AllDo.Infrastructure.Data.Models;
using AllDo.Infrastructure.Data.Repositories;
using AllDo.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BugsController : ControllerBase
{
    private readonly IRepository<BugDto> repository;
    private readonly ICsvProcessor csvProcessor;

    public BugsController(IRepository<BugDto> repository, ICsvProcessor csvProcessor)
    {
        this.csvProcessor = csvProcessor;
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
    public async Task<IActionResult> Create([FromBody] BugDto bugToCreate)
    {
        await repository.AddAsync(bugToCreate);

        return CreatedAtAction(nameof(GetById), new { id = bugToCreate.Id }, bugToCreate);
    }

    [HttpPost("bulk-create")]
    public async Task<IActionResult> BulkCreate(IFormFile csvFile)
    {
        if (csvFile is null)
        {
            return BadRequest("No CSV file was provided.");
        }

        var bugsToCreate = new List<BugDto>();
        try
        {
            bugsToCreate = csvProcessor.ExtractBugsFromFile(csvFile);
        }
        catch (Exception e)
        {
            return BadRequest("Invalid CSV file provided.");
        }

        var result = await repository.AddBulkAsync(bugsToCreate);

        return result ? CreatedAtAction(nameof(GetAll), new { }, result) : BadRequest("Unable to create bugs.");
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await repository.DeleteAsync(id);
        if (!result) return BadRequest("Couldn't delete");

        return NoContent();
    }

}