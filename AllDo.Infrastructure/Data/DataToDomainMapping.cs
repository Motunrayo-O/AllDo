using AllDo.Infrastructure.Data.Models;

namespace AllDo.Infrastructure.Data;

public class DataToDomainMapping
{
    public static TTo MapTodoFromData<TFrom, TTo>(TFrom input)
        where TFrom : Data.Models.Todo
        where TTo : Domain.Todo
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

    private static Domain.TodoTask MapTask(Models.TodoTask task)
    {
        return new Domain.TodoTask(task.Title, task.DueDate, MapUser(task.CreatedBy))
        {
            Id = task.Id
        };
    }

    private static Domain.Feature MapFeature(Models.Feature feature)
    {
        return new(feature.Title, feature.Description, feature.Component, feature.Priority, MapUser(feature.CreatedBy), MapUser(feature.AssignedTo))
        {
            Id = feature.Id,
            DueDate = feature.DueDate,
            IsCompleted = feature.IsCompleted
        };
    }

    private static Domain.Bug MapBug(Models.Bug bug)
    {
        return new(bug.Title, bug.Description, (Domain.Severity)bug.Severity, bug.AffectedVersion, bug.AffectedUsers,
        MapUser(bug.CreatedBy), MapUser(bug.AssignedTo), bug.Images?.Select(image => Convert.FromBase64String(image.ImageData)).ToArray() ?? Enumerable.Empty<byte[]>())
        {
            Id = bug.Id,
            DueDate = bug.DueDate
        };
    }

    public static Domain.User MapUser(User input)
    {
        if (input is null) return null!;

        return new(input.Name)
        {
            Id = input.Id
        };
    }
}
