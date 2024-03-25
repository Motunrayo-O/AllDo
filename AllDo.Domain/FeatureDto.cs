namespace AllDo.Domain;

public record FeatureDto(string Title, string Description, string Component, int Priority, UserDto CreatedBy, UserDto AssignedTo)
: TodoTaskDto(Title, DateTimeOffset.MinValue, CreatedBy);
