using AllDo.Domain;
using Microsoft.EntityFrameworkCore;

namespace AllDo.Infrastructure.Data.Repositories;

public class FeatureRepository : TodoRepository<FeatureDto>
{
    public FeatureRepository(AllDoDbContext context) : base(context)
    {
    }

    public override async Task AddAsync(FeatureDto featureDTO)
    {
        var exisitingFeature = await Context.Features.FirstOrDefaultAsync(f => f.Id == featureDTO.Id);
        var createdBy = await Context.Users.SingleAsync(u => u.Id == featureDTO.CreatedBy.Id);
        createdBy ??= new() { Name = featureDTO.CreatedBy.Name, Id = featureDTO.CreatedBy.Id };

        if (exisitingFeature is not null)
            await UpdateFeatureAsync(exisitingFeature, featureDTO, createdBy);
        else
            await CreateFeatureAsync(featureDTO, createdBy);
    }

    private async Task UpdateFeatureAsync(Models.Feature exisitingFeature, FeatureDto featureDTO, Models.User user)
    {
        exisitingFeature.AssignedTo = await Context.Users.SingleAsync(u => u.Id == featureDTO.Id);
        exisitingFeature.Title = featureDTO.Title;
        exisitingFeature.Component = featureDTO.Component;
        exisitingFeature.Description = featureDTO.Description;
        exisitingFeature.Priority = featureDTO.Priority;


        exisitingFeature.CreatedBy = user;

        await SetParentAsync(exisitingFeature, featureDTO);

        Context.Features.Update(exisitingFeature);
    }

    private async Task CreateFeatureAsync(FeatureDto featureDTO, Models.User user)
    {
        var featureToAdd = new Models.Feature()
        {
            Title = featureDTO.Title,
            Description = featureDTO.Description,
            Component = featureDTO.Component,
            Priority = featureDTO.Priority,
            AssignedTo = user,
            CreatedBy = user
        };

        await SetParentAsync(featureToAdd, featureDTO);
        await Context.Features.AddAsync(featureToAdd);

    }

    public override async Task<FeatureDto> GetAsync(Guid id)
    {
        var result = await Context.Features.SingleAsync(f => f.Id == id);

        return DataToDTOMapping.MapToDTO<Models.Feature, FeatureDto>(result);
    }
}
