using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class BugRepository : TodoRepository<BugDto>
{
    public BugRepository(AllDoDbContext context) : base(context)
    {
    }

    public override async Task AddAsync(BugDto item)
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

        await SaveChangesAsync();
    }

    public override async Task<BugDto?> GetAsync(Guid id)
    {
        var result = await Context.Bugs.FindAsync(id);
        if (result is not null)
            return DataToDTOMapping.MapToDTO<Models.Bug, BugDto>(result);

        return null;
    }

    public async override Task<IEnumerable<BugDto>> AllAsync()
    {
        var result = await Context.Bugs.Where(t => !t.IsDeleted).Include(t => t.CreatedBy).Include(t => t.Parent)
            .Select(t => DataToDTOMapping.MapToDTO<Models.Bug, BugDto>(t))
            .ToArrayAsync();

        return result;
    }

    private async Task CreateBugAsync(BugDto item, Models.User createdBy)
    {
        var bugToCreate = DTOToDataMapping.MapToData<BugDto, Models.Bug>(item);
        await SetParentAsync(bugToCreate, item);

        bugToCreate.CreatedBy = createdBy;
        await Context.Bugs.AddAsync(bugToCreate);
    }



    private async Task UpdateBugAsync(BugDto item, Models.Bug existingBug, Models.User createdBy)
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
