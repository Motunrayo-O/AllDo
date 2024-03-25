using AllDo.Infrastructure.Data.Models;

namespace AllDo.Infrastructure.Data;

public class DataToDTOMapping
{
    public static TTo MapToDTO<TFrom, TTo>(TFrom input)
        where TFrom : Data.Models.Todo
        where TTo : Domain.TodoDto
    {
        var model = input switch
        {
            Models.Bug bug => MapBug(bug),
            Models.Feature feature => MapFeature(feature),
            Models.TodoTask task => MapTask(task),
            _ => throw new NotImplementedException()
        } as TTo;


        return model;
    }

    private static Domain.TodoTaskDto MapTask(Models.TodoTask task)
    {
        return new Domain.TodoTaskDto(task.Title, task.DueDate)
        {
            Id = task.Id
        };
    }

    private static Domain.FeatureDto MapFeature(Models.Feature feature)
    {
        return new(feature.Title, feature.Description, feature.Component, feature.Priority, MapUser(feature.AssignedTo))
        {
            Id = feature.Id,
            DueDate = feature.DueDate,
            IsCompleted = feature.IsCompleted
        };
    }

    private static Domain.BugDto MapBug(Models.Bug bug)
    {
        return new(bug.Title, bug.Description,  bug.AffectedVersion, bug.AffectedUsers, MapUser(bug.AssignedTo), bug.Images?.Select(image => Convert.FromBase64String(image.ImageData)).ToArray() ?? Enumerable.Empty<byte[]>(), (Domain.Severity)bug.Severity)
        {
            Id = bug.Id,
            DueDate = bug.DueDate
        };
    }

    public static Domain.UserDto MapUser(User input)
    {
        if (input is null) return null!;

        return new(input.Name)
        {
            Id = input.Id
        };
    }
}
