using AllDo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        var users = new List<User>
        {
            new User(){Name = "Jason Derulo", Id= Guid.NewGuid()}
        };

        builder.Entity<User>().HasData(users);

        builder.Entity<Bug>().HasData(new List<Bug>{
            new Bug() {
                Id = Guid.NewGuid(),
                Title = "Fix Alignment",
                Description = "Alignment on second wizard screen uneven",
                Severity = Severity.Critical,
                DueDate = DateTimeOffset.UtcNow.AddDays(4),
                AffectedUsers = 5,
                AffectedVersion = "1.2",
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-10),
                CreatedById = users[0].Id
            }
        });
    }
}