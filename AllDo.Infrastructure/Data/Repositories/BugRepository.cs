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

    public override async Task<bool> AddBulkAsync(IEnumerable<BugDto> items)
    {
        try
        {
            var createdByUserIds = items.Select(i => i.CreatedBy.Id);
            var createdByUserList = await Context.Users.Where(u => createdByUserIds.Contains(u.Id)).ToListAsync();
            var userById = createdByUserList.ToDictionary(u => u.Id);

            var bugsToCreate = new List<Models.Bug>();
            foreach (var bugDto in items)
            {
                var bugToCreate = DTOToDataMapping.MapToData<BugDto, Models.Bug>(bugDto);
                var createdBy = userById[bugDto.CreatedBy.Id];
                // await SetParentAsync(bugToCreate, bugDto);

                bugToCreate.CreatedBy = createdBy;
                bugsToCreate.Add(bugToCreate);
            }
            await Context.Bugs.AddRangeAsync(bugsToCreate);
            await SaveChangesAsync();
        }
        catch (System.Exception)
        {
            return false;
        }

        return true;
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
