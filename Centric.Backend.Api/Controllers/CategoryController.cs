using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc;

using Dapper;

using Centric.Backend.Domain.Model;

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
    public IEnumerable<Category> Get()
    {
        using var connection = new SqlConnection(_connectString);
        var categories = connection.Query<Category>("SELECT * FROM Category").ToList();

        return categories;
    }
}