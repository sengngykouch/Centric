using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

using Centric.Backend.Domain.Model.Transaction;
using Centric.Backend.Persistance.Repositories;

namespace Centric.Backend.Api.Controllers;

[Route("api/[controller]")]
public class TransactionController : ControllerBase
{
    private readonly string _connectString;

    public TransactionController(IConfiguration configuration)
    {
        _connectString = configuration.GetConnectionString("DefaultConnection")!;
    }

    [HttpGet]
    public async Task<ImmutableList<Transaction>> Get()
    {
        return await TransactionRepository.Get(_connectString);
    }
}