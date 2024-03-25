namespace AllDo.Domain;

public abstract record TodoDto(string Title, DateTimeOffset CreatedDate, bool IsCompleted = false, bool IsDeleted = false)
{
    public TodoDto? Parent { get; init; }

    public Guid Id { get; set; } = Guid.NewGuid();

//TODO Assign to Logged in user
    public UserDto CreatedBy { get; set; } = new UserDto("Jason Derulo"){Id = Guid.Parse("644D7218-42F9-479C-8436-EBE5224AF97E")};
}
