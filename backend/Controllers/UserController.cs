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
    private readonly IMapper _mapper;
    public UserController(IUserService service, IMapper mapper)
    {
        _dbservice = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<UserDTO>>> GetAll()
    {
        var users = await _dbservice.GetAll();
        return Ok(_mapper.Map<List<UserDTO>>(users));
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> GetById([FromRoute] int id)
    {
        var user = await _dbservice.GetById(id);
        if (user == null) return NotFound();
        return Ok(_mapper.Map<UserDTO>(user));
    }

    [HttpPost]
    public async Task<ActionResult<List<UserDTO>>> Add([FromBody]UserDTO new_user)
    {
        var user = _mapper.Map<User>(new_user);
        await _dbservice.Create(user);
       
        var users = await _dbservice.GetAll();
        return Ok(_mapper.Map<List<UserDTO>>(users));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<UserDTO>>> DeleteById([FromRoute]int id)
    {
        var user = await _dbservice.GetById(id);
        if (user == null) return NotFound();
        await _dbservice.Delete(user);
        var users = await _dbservice.GetAll();
        return Ok(_mapper.Map<List<UserDTO>>(users));
    }
}