using Centric.Backend.Domain.Model;
using Microsoft.AspNetCore.Mvc;

namespace Centric.Backend.Api;

[Route("api/[controller]")]
public class CategoryController : ControllerBase
{

    [HttpGet]
    public IEnumerable<Category> Get()
    {
        return [];
    }
}