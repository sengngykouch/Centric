using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

using Centric.Backend.Domain.Model.User;
using Centric.Backend.Persistance.Repositories;

namespace Centric.Backend.Api.Controllers;

[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly string _connectString;

    public UserController(IConfiguration configuration)
    {
        _connectString = configuration.GetConnectionString("DefaultConnection")!;
    }

    [HttpGet]
    public async Task<ImmutableList<User>> Get()
    {
        return await UserRepository.Get(_connectString);
    }

    // [HttpPost]
    // public async Task<bool> Add([FromBody] UserRequest request)
    // {
    //     return await UserRepository.Add(_connectString, request);
    // }

}