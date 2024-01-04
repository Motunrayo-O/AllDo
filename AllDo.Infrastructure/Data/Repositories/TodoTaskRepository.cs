using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class TodoTaskRepository : TodoRepository<TodoTask>
{
    public TodoTaskRepository(AllDoDbContext context) : base(context)
    {
    }

    public override async Task AddAsync(TodoTask item)
    {
        await this.Context.TodoTasks.AddAsync(DTOToDataMapping.MapToData<TodoTask, Models.TodoTask>(item));
    }

    public override async Task<TodoTask> GetAsync(Guid id)
    {
        var result = await this.Context.TodoTasks.SingleAsync(t => t.Id == id);
        return DataToDTOMapping.MapToDTO<Models.TodoTask, TodoTask>(result);
    }
}