using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Category;
using Centric.Backend.Persistance.Repositories;

namespace Centric.Backend.Api.Controllers;

[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private readonly string _connectString;

    public CategoryController(IConfiguration configuration)
    {
        _connectString = configuration.GetConnectionString("DefaultConnection")!;
    }

    [HttpGet]
    public async Task<ImmutableList<Category>> Get()
    {
        return await CategoryRepository.Get(_connectString);
    }

    [HttpPost]
    public async Task<bool> Add([FromBody] CategoryRequest request)
    {
        return await CategoryRepository.Add(_connectString, request);
    }

}