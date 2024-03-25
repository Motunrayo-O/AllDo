namespace AllDo.Domain;

public record TodoTaskDto(string Title, DateTimeOffset DueDate) : TodoDto(Title, DateTimeOffset.UtcNow);

