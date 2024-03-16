using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class BugRepository : TodoRepository<Bug>
{
    public BugRepository(AllDoDbContext context) : base(context)
    {
    }

    public override async Task AddAsync(Bug item)
    {
        var existingBug = await Context.Bugs.FirstOrDefaultAsync(b => b.Id == item.Id);

        var createdBy = await Context.Users.FirstOrDefaultAsync(u => u.Id == item.CreatedBy.Id);

        createdBy ??= new() { Id = item.CreatedBy.Id, Name = item.CreatedBy.Name };

        if (existingBug is not null)
        {
            await UpdateBugAsync(item, existingBug, createdBy);
        }
        else
        {
            await CreateBugAsync(item, createdBy);
        }
    }

    public override async Task<Bug> GetAsync(Guid id)
    {
        var result = await Context.Bugs.SingleAsync(b => b.Id == id);

        return DataToDTOMapping.MapToDTO<Models.Bug, Bug>(result);
    }

    public async override Task<IEnumerable<Bug>> AllAsync()
    {
        var result = await Context.Bugs.Where(t => !t.IsDeleted).Include(t => t.CreatedBy).Include(t => t.Parent)
            .Select(t => DataToDTOMapping.MapToDTO<Models.Bug, Bug>(t))
            .ToArrayAsync();

        return result;
    }

    private async Task CreateBugAsync(Bug item, Models.User createdBy)
    {
        var bugToCreate = DTOToDataMapping.MapToData<Bug, Models.Bug>(item);
        await SetParentAsync(bugToCreate, item);

        bugToCreate.CreatedBy = createdBy;
        await Context.Bugs.AddAsync(bugToCreate);
    }



    private async Task UpdateBugAsync(Bug item, Models.Bug existingBug, Models.User createdBy)
    {
        existingBug.Title = item.Title;
        existingBug.IsCompleted = item.IsCompleted;
        existingBug.AffectedUsers = item.AffectedUsers;
        existingBug.AffectedVersion = item.AffectedVersion;
        existingBug.Description = item.Description;
        existingBug.Severity = (Data.Models.Severity)item.Severity;

        await SetParentAsync(existingBug, item);

        Context.Bugs.Update(existingBug);
    }


}
