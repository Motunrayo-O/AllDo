using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class TodoTaskRepository : TodoRepository<TodoTaskDto>
{
    public TodoTaskRepository(AllDoDbContext context) : base(context)
    {
    }

    public override async Task AddAsync(TodoTaskDto item)
    {
        await this.Context.TodoTasks.AddAsync(DTOToDataMapping.MapToData<TodoTaskDto, Models.TodoTask>(item));
    }

    public override async Task<TodoTaskDto> GetAsync(Guid id)
    {
        var result = await this.Context.TodoTasks.SingleAsync(t => t.Id == id);
        return DataToDTOMapping.MapToDTO<Models.TodoTask, TodoTaskDto>(result);
    }
}