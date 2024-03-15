using AllDo.Domain;
using AllDo.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly IRepository<TodoTask> repository;

    public TodosController(IRepository<TodoTask> repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await repository.AllAsync());
    }
}