using System.Collections.Concurrent;
using AllDo.Domain;

namespace AllDo.Infrastructure.Data.Repositories;

public class TodoInMemoryRepository<T> : IRepository<T> where T : Todo
{
    private ConcurrentDictionary<Guid, T> Items { get; } = new();

    public Task AddAsync(T item)
    {
        Items.TryAdd(item.Id, item);

        return Task.CompletedTask;
    }

    public Task<IEnumerable<T>> AllAsync()
    {
        var items = Items.Values.ToArray();

        return Task.FromResult<IEnumerable<T>>(items);
    }

    public Task<bool> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<T> FindbyAsync(string value)
    {
        var result = Items.Values.First(i => i.Title == value);

        return Task.FromResult<T>(result);
    }

    public Task<T> GetAsync(Guid id)
    {
        return Task.FromResult<T>(Items[id]);
    }

    public Task SaveChangesAsync()
    {
        return Task.CompletedTask;
    }
}