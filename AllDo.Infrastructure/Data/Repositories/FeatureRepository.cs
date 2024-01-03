using AllDo.Domain;

namespace AllDo.Infrastructure.Data.Repositories;

public class FeatureRepository : TodoRepository<Feature>
{
    public FeatureRepository(AllDoDbContext context) : base(context)
    {
    }

    public override Task AddAsync(Feature item)
    {
        throw new NotImplementedException();
    }

    public override Task<Feature> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}