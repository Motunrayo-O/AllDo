namespace AllDo.Infrastructure.Data.Models;

public class Bug : TodoTask
{
    public string Description { get; set; } = default!;
    public User? AssignedTo { get; set; } = default;

    public Severity Severity { get; set; }
    public string AffectedVersion { get; set; } = string.Empty;

    public int AffectedUsers { get; set; }
    public virtual ICollection<Image> Images { get; set; } = default!;

    //TODO: many to many relationship?
    public Guid? ImageId { get; set; } = default;
}
