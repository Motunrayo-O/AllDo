namespace AllDo.Domain;

public record TodoTaskDto(string Title, DateTimeOffset DueDate, UserDto CreatedBy) : TodoDto(Guid.NewGuid(), Title, DateTimeOffset.UtcNow, CreatedBy);

