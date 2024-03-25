namespace AllDo.Domain;

public record UserDto(string Name)
{
    public Guid Id { get; init; } = Guid.NewGuid();
}
