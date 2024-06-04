﻿using Evently.Common.Application.Caching;
using Evently.Common.Domain.Abstractions;
using Evently.Common.Presentation.ApiResults;
using Evently.Common.Presentation.Endpoints;
using Evently.Modules.Events.Application.Categories.GetCategories;
using Evently.Modules.Events.Application.Categories.GetCategory;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace Evently.Modules.Events.Presentation.Categories;

internal sealed class GetCategories : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("categories", async (ISender sender, ICacheService cacheService) =>
            {
                const string categoriesKey = "categories";
                
                IReadOnlyCollection<CategoryResponse> categoryResponses =
                    await cacheService.GetAsync<IReadOnlyCollection<CategoryResponse>>(categoriesKey);

                if (categoryResponses is not null)
                {
                    return Results.Ok(categoryResponses);
                }

                Result<IReadOnlyCollection<CategoryResponse>> result = await sender.Send(new GetCategoriesQuery());

                if (result.IsSuccess)
                {
                    await cacheService.SetAsync(categoriesKey, result.Value);
                }

                return result.Match(Results.Ok, ApiResults.Problem);
            })
            .WithTags(Tags.Categories);
    }
}
