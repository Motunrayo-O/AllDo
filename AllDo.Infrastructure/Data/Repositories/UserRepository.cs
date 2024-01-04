using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class UserRepository : IRepository<User>
{
    public UserRepository(AllDoDbContext context)
    {
        Context = context;
    }

    private AllDoDbContext Context { get; }

    public async Task AddAsync(User userDTO)
    {
        var existingUser = await Context.Users.FirstOrDefaultAsync(u => u.Id == userDTO.Id);
        if (existingUser is not null)
            UpdateUserAsync(existingUser, userDTO);
        else
            CreateUserAsync(userDTO);
    }

    private void UpdateUserAsync(Models.User existingUser, User dto)
    {
        existingUser.Name = dto.Name;
        Context.Users.Update(existingUser);
    }

    private async Task CreateUserAsync(User dto)
    {
        Models.User user = new() { Name = dto.Name };
        await Context.Users.AddAsync(user);
    }

    public async Task<IEnumerable<User>> AllAsync()
    {
        return await Context.Users.Select(u => DataToDTOMapping.MapUser(u)).ToArrayAsync();
    }

    public async Task<User> FindbyAsync(string value)
    {
        var user = await Context.Users.SingleAsync(u => u.Name == value);
        return DataToDTOMapping.MapUser(user);
    }

    public async Task<User> GetAsync(Guid id)
    {
        var user = await Context.Users.SingleAsync(u => u.Id == id);
        return DataToDTOMapping.MapUser(user);
    }

    public async Task SaveChangesAsync()
    {
        await Context.SaveChangesAsync();
    }
}