using AllDo.Infrastructure.Data.Models;

namespace AllDo.Infrastructure.Data;

public class DTOToDataMapping
{

    public static TTo MapToData<TFrom, TTo>(TFrom input)
        where TFrom : Domain.TodoDto
        where TTo : Models.Todo
    {
        return input switch
        {
            Domain.BugDto bug => MapBug(bug),
            Domain.FeatureDto feature => MapFeature(feature),
            Domain.TodoTaskDto task => MapTask(task),
            _ => throw new NotImplementedException()
        } as TTo;
    }

    private static TodoTask MapTask(Domain.TodoTaskDto task)
    {
        return new()
        {
            Title = task.Title,
            Id = task.Id,
            CreatedDate = task.CreatedDate,
            CreatedBy = MapUser(task.CreatedBy),
            IsCompleted = task.IsCompleted,
            IsDeleted = task.IsDeleted,
            DueDate = task.DueDate,
        };
    }

    private static Feature MapFeature(Domain.FeatureDto feature)
    {
        return new()
        {
            Title = feature.Title,
            Id = feature.Id,
            CreatedDate = feature.CreatedDate,
            CreatedBy = MapUser(feature.CreatedBy),
            IsCompleted = feature.IsCompleted,
            IsDeleted = feature.IsDeleted,
            DueDate = feature.DueDate,
            Description = feature.Description,
            AssignedTo = MapUser(feature.AssignedTo),
            Component = feature.Component,
            Priority = feature.Priority,
        };
    }

    private static Bug MapBug(Domain.BugDto bug)
    {
        return new()
        {
            Title = bug.Title,
            Id = bug.Id,
            CreatedDate = bug.CreatedDate,
            CreatedBy = MapUser(bug.CreatedBy),
            IsCompleted = bug.IsCompleted,
            IsDeleted = bug.IsDeleted,
            DueDate = bug.DueDate,
            Description = bug.Description,
            AssignedTo = bug.AssignedTo != null ? MapUser(bug.AssignedTo) : null,
            Severity = (Models.Severity)bug.Severity,
            AffectedUsers = bug.AffectedUsers,
            AffectedVersion = bug.AffectedVersion,
            Images = bug.Images.Select(im => new Image() { ImageData = Convert.ToBase64String(im) }).ToArray()
        };
    }

    public static User MapUser(Domain.UserDto input)
    {
        return new() { Id = input.Id, Name = input.Name };
    }
}
