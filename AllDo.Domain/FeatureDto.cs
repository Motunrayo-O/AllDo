namespace AllDo.Domain;

public record FeatureDto(string Title, string Description, string Component, int Priority, UserDto AssignedTo)
: TodoTaskDto(Title, DateTimeOffset.MinValue);
