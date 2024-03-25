namespace AllDo.Domain;

public abstract record TodoDto(Guid Id, string Title, DateTimeOffset CreatedDate, UserDto CreatedBy, bool IsCompleted = false, bool IsDeleted = false)
{
    public TodoDto? Parent { get; init; }
}
