using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Budget;
using Centric.Backend.Persistance.Repositories;

namespace Centric.Backend.Api.Controllers;

[Route("api/[controller]")]
public class BudgetController : ControllerBase
{
    private readonly string _connectString;

    public BudgetController(IConfiguration configuration)
    {
        _connectString = configuration.GetConnectionString("DefaultConnection")!;
    }

    [HttpGet]
    public async Task<ImmutableList<Budget>> Get()
    {
        return await BudgetRepository.Get(_connectString);
    }

    // [HttpPost]
    // public async Task<bool> Add([FromBody] BudgetRequest request)
    // {
    //     return await BudgetRepository.Add(_connectString, request);
    // }

}