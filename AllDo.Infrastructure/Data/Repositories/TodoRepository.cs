using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public abstract class TodoRepository<T> : IRepository<T> where T : TodoTask
{
    protected AllDoDbContext Context { get; }

    public TodoRepository(AllDoDbContext context)
    {
        this.Context = context;
    }



    public virtual async Task<IEnumerable<T>> AllAsync()
    {
        return await Context.TodoTasks.Where(t => !t.IsDeleted).Include(t => t.CreatedBy).Include(t => t.Parent)
            .Select(t => DataToDomainMapping.MapTodoFromData<Models.TodoTask, T>(t))
            .ToArrayAsync();
    }

    public virtual async Task<T> FindbyAsync(string value)
    {
        var task = await Context.TodoTasks.SingleAsync(t => t.Title == value);
        return DataToDomainMapping.MapTodoFromData<Models.TodoTask, T>(task);
    }

    public async Task SaveChangesAsync()
    {
        await Context.SaveChangesAsync();
    }

    public abstract Task AddAsync(T item);

    public abstract Task<T> GetAsync(Guid id);

    protected async Task SetParentAsync(Models.Bug bugToCreate, Bug bugDTO)
    {
        Data.Models.TodoTask? existingParent = null;
        if (bugDTO.Parent is not null)
        {
            existingParent = await Context.Bugs.FirstOrDefaultAsync(b => b.Id == bugDTO.Parent.Id);
        }

        if (bugDTO.Parent is not null)
        {
            var parentToCreate = DomainToDataMapping.MapTodoFromDomain<Domain.Bug, Models.Bug>(bugDTO);
            await Context.AddAsync(parentToCreate);
            existingParent ??= parentToCreate;

        }
        bugToCreate.Parent = existingParent;
    }

}