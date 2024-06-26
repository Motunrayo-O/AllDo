using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class UserRepository : IRepository<UserDto>
{
    public UserRepository(AllDoDbContext context)
    {
        Context = context;
    }

    private AllDoDbContext Context { get; }

    public async Task AddAsync(UserDto userDTO)
    {
        var existingUser = await Context.Users.FirstOrDefaultAsync(u => u.Id == userDTO.Id);
        if (existingUser is not null)
            UpdateUserAsync(existingUser, userDTO);
        else
            CreateUserAsync(userDTO);
    }

    private void UpdateUserAsync(Models.User existingUser, UserDto dto)
    {
        existingUser.Name = dto.Name;
        Context.Users.Update(existingUser);
    }

    private async Task CreateUserAsync(UserDto dto)
    {
        Models.User user = new() { Name = dto.Name };
        await Context.Users.AddAsync(user);
    }

    public async Task<IEnumerable<UserDto>> AllAsync()
    {
        return await Context.Users.Select(u => DataToDTOMapping.MapUser(u)).ToArrayAsync();
    }

    public async Task<UserDto> FindbyAsync(string value)
    {
        var user = await Context.Users.SingleAsync(u => u.Name == value);
        return DataToDTOMapping.MapUser(user);
    }

    public async Task<UserDto> GetAsync(Guid id)
    {
        var user = await Context.Users.SingleAsync(u => u.Id == id);
        return DataToDTOMapping.MapUser(user);
    }

    public async Task SaveChangesAsync()
    {
        await Context.SaveChangesAsync();
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AddBulkAsync(IEnumerable<UserDto> items)
    {
        throw new NotImplementedException();
    }
}