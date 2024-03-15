using AllDo.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data;

public static class SeedData
{
    public static void Seed(ModelBuilder builder)
    {
        var users = new List<User>
        {
            new User(){Name = "Jason Derulo", Id= Guid.NewGuid()},
            new User(){Name = "Robyn Fenty", Id= Guid.NewGuid()},
            new User(){Name = "Paul Dyson", Id= Guid.NewGuid()},
            new User(){Name = "Tiwa Savage", Id= Guid.NewGuid()},
            new User(){Name = "Mohbad ", Id= Guid.NewGuid()}
        };

        builder.Entity<User>().HasData(users);

        // var image1 = new Image
        // {
        //     Id = Guid.NewGuid(),
        //     ImageData = "iVBORw0KGgoAAAANSUhEUgAAAQAAAAEACAIAAADTED8xAAADMElEQVR4nOzVwQnAIBQFQYXff81RUkQCOyDj1YOPnbXWPmeTRef+/3O/OyBjzh3CD95BfqICMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMO0TAAD//2Anhf4QtqobAAAAAElFTkSuQmCC"
        // };

        // builder.Entity<Bug>().HasData(image1);

        builder.Entity<Bug>().HasData(new List<Bug>{
            new Bug() {
                Id = Guid.NewGuid(),
                Title = "Fix Alignment",
                Description = "Alignment on second wizard screen uneven",
                Severity = Severity.Minor,
                DueDate = DateTimeOffset.UtcNow.AddDays(4),
                AffectedUsers = 5,
                AffectedVersion = "1.2",
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-10),
                CreatedById = users[0].Id
                // Images = new List<Image>{image1},
                // ImageId = image1.Id,
            },
            new Bug() {
                Id = Guid.NewGuid(),
                Title = "Splash Screen Exception",
                Description = "Array Index out of bounds ecxeption",
                Severity = Severity.Critical,
                DueDate = DateTimeOffset.UtcNow.AddDays(1),
                AffectedUsers = 450,
                AffectedVersion = "1.2",
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-1),
                CreatedById = users[1].Id
            },
                new Bug() {
                Id = Guid.NewGuid(),
                Title = "Summary Calculations Wrong",
                Description = "Incorrect Result calculated for Interest repayments",
                Severity = Severity.Critical,
                DueDate = DateTimeOffset.UtcNow.AddDays(18),
                AffectedUsers = 200,
                AffectedVersion = "1.2",
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-10),
                CreatedById = users[4].Id
}
        });


        // Features
        builder.Entity<Feature>().HasData(new List<Feature>{
            new Feature() {
                Id = Guid.NewGuid(),
                Title = "Fractional Interest Rates",
                Description = "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.",
                DueDate = DateTimeOffset.UtcNow.AddDays(4),
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-10),
                CreatedById = users[0].Id,
                AssignedToId = users[2].Id,
                Component = "Component 1"

            },
            new Feature() {
                Id = Guid.NewGuid(),
                Title = "Advisor Insights",
                Description = "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.",
                DueDate = DateTimeOffset.UtcNow.AddDays(1),
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-1),
                CreatedById = users[1].Id,
                AssignedToId = users[2].Id,
                Component = "Component 2"
            },
                new Feature() {
                Id = Guid.NewGuid(),
                Title = "User Preferences",
                Description = "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo",
                DueDate = DateTimeOffset.UtcNow.AddDays(18),
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-10),
                CreatedById = users[4].Id,
                AssignedToId = users[2].Id,
                Component = "Component 3"
            },
                new Feature() {
                Id = Guid.NewGuid(),
                Title = "Split Payments",
                Description = "Shortbread shortbread I love cake chocolate marzipan.. Tart marshmallow halvah powder jelly-o wafer macaroo",
                DueDate = DateTimeOffset.UtcNow.AddDays(18),
                CreatedDate = DateTimeOffset.UtcNow.AddDays(-10),
                CreatedById = users[4].Id,
                AssignedToId = users[2].Id,
                Component = "Component 2"
            }
        });




    }
}