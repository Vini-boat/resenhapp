using Microsoft.AspNetCore.Mvc;
using AutoMapper;

using Resenhapp.Services.Interfaces;

using Resenhapp.Repositories.DTOs;
using Resenhapp.Repositories.Models;

namespace Resenhapp.Controllers;

[Route("api/user/")]
[ApiController]
public class UserController: ControllerBase
{
    private readonly IUserService _dbservice;
    public UserController(IUserService service, IMapper mapper)
    {
        _dbservice = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDTO>>> GetAll()
    {
        return Ok(await _dbservice.GetAll());
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> GetById([FromRoute] int id)
    {
        var user = await _dbservice.GetById(id);
        if (user == null) return NotFound();
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<List<UserDTO>>> Add([FromBody]UserDTO new_user)
    {
        await _dbservice.Create(new_user);
        return Ok(await _dbservice.GetAll());
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<UserDTO>>> DeleteById([FromRoute]int id)
    {
        try{await _dbservice.DeleteById(id);}
        catch (Exception) {return NotFound();}
        return Ok(await _dbservice.GetAll());
    }
}