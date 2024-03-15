namespace AllDo.Infrastructure.Data.Models;

public abstract class Todo
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string Title { get; set; } = default!;

    public DateTimeOffset CreatedDate { get; set; } = DateTimeOffset.UtcNow;

    // Navigation Property
    public User CreatedBy { get; set; } = default!;

    //Foreign Key Property
    public Guid CreatedById { get; set; }

    public bool IsCompleted { get; set; }
    public bool IsDeleted { get; set; }
    public virtual Todo? Parent { get; set; }
}