using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public abstract class TodoRepository<T> : IRepository<T> where T : TodoTaskDto
{
    protected AllDoDbContext Context { get; }

    public TodoRepository(AllDoDbContext context)
    {
        this.Context = context;
    }



    public virtual async Task<IEnumerable<T>> AllAsync()
    {
        return await Context.TodoTasks.Where(t => !t.IsDeleted).Include(t => t.CreatedBy).Include(t => t.Parent)
            .Select(t => DataToDTOMapping.MapToDTO<Models.TodoTask, T>(t))
            .ToArrayAsync();
    }

    public virtual async Task<T> FindbyAsync(string value)
    {
        var task = await Context.TodoTasks.SingleAsync(t => t.Title == value);
        return DataToDTOMapping.MapToDTO<Models.TodoTask, T>(task);
    }

    public async Task SaveChangesAsync()
    {
        await Context.SaveChangesAsync();
    }

    public abstract Task AddAsync(T item);

    public abstract Task<T> GetAsync(Guid id);

    protected async Task SetParentAsync(Models.Bug bugToCreate, BugDto bugDTO)
    {
        Data.Models.TodoTask? existingParent = null;
        if (bugDTO.Parent is not null)
        {
            existingParent = await Context.Bugs.FirstOrDefaultAsync(b => b.Id == bugDTO.Parent.Id);
        }

        if (bugDTO.Parent is not null)
        {
            var parentToCreate = DTOToDataMapping.MapToData<Domain.BugDto, Models.Bug>(bugDTO);
            await Context.AddAsync(parentToCreate);
            existingParent ??= parentToCreate;

        }
        bugToCreate.Parent = existingParent;
    }

    protected async Task SetParentAsync(Models.Feature featureToCreate, FeatureDto featureDTO)
    {
        Data.Models.TodoTask? existingParent = null;
        if (featureDTO.Parent is not null)
        {
            existingParent = await Context.Bugs.FirstOrDefaultAsync(b => b.Id == featureDTO.Parent.Id);
        }

        if (featureDTO.Parent is not null)
        {
            var parentToCreate = DTOToDataMapping.MapToData<Domain.FeatureDto, Models.Feature>(featureDTO);
            await Context.AddAsync(parentToCreate);
            existingParent ??= parentToCreate;

        }
        featureToCreate.Parent = existingParent;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var task = await Context.TodoTasks.FindAsync(id);
        if (task is not null)
        {
            task.IsDeleted = true;
            await SaveChangesAsync();
            return true;
        }
        return false;
    }

    public virtual Task<bool> AddBulkAsync(IEnumerable<T> items)
    {
        throw new NotImplementedException();
    }
}
