namespace AllDo.Domain;

public enum Severity
{
    Critical,
    Major,
    Minor,
    Irritating
}
public record BugDto(string Title, string Description,  string AffectedVersion,
int AffectedUsers, UserDto? AssignedTo, IEnumerable<Byte[]> Images,Severity Severity = Severity.Minor) : TodoTaskDto(Title, DateTimeOffset.MinValue);
