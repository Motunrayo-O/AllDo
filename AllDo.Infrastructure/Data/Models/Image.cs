namespace AllDo.Infrastructure.Data.Models;

public class Image
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BugId { get; set; } = Guid.NewGuid();

    public Bug Bug { get; set; } = default!;

    public string ImageData { get; set; } = default!;
}