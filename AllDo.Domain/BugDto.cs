namespace AllDo.Domain;

public enum Severity
{
    Critical,
    Major,
    Minor,
    Irritating
}
public record BugDto(string Title, string Description, Severity Severity, string AffectedVersion,
int AffectedUsers, UserDto CreatedBy, UserDto? AssignedTo, IEnumerable<Byte[]> Images) : TodoTaskDto(Title, DateTimeOffset.MinValue, CreatedBy);
