using AllDo.Domain;
using AllDo.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TodosController : ControllerBase
{
    private readonly IRepository<TodoTaskDto> repository;

    public TodosController(IRepository<TodoTaskDto> repository)
    {
        this.repository = repository;
    }

    [HttpGet]
    public async virtual Task<IActionResult> GetAll()
    {
        return Ok(await repository.AllAsync());
    }
}