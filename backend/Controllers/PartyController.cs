using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Resenhapp.Services.Interfaces;

using Resenhapp.Repositories.DTOs;
using Resenhapp.Repositories.Models;

namespace Resenhapp.Controllers;

[Route("api/party/")]
[ApiController]
public class PartyController: ControllerBase
{
    private readonly IMapper _mapper;
    private readonly IPartyService _dbservice;
    public PartyController(IMapper mapper, IPartyService service)
    {
        _mapper = mapper;
        _dbservice = service;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PartyDTO>> GetById([FromRoute] int id)
    {
        var party = await _dbservice.GetById(id);
        if (party == null) return NotFound();
        return Ok(party);
    }

    [HttpGet("user/{id}")]
    public async Task<ActionResult<List<PartyDTO>>> GetByUserId([FromRoute] int id)
    {
        var parties = await _dbservice.GetByUserId(id);
        if (parties == null) return NotFound();
        return Ok(parties);
    }

    [HttpPost]
    public async Task<ActionResult<PartyDTO>> Add([FromBody] PartyDTO party)
    {
        var new_party = _mapper.Map<Party>(party);
        await _dbservice.Create(new_party);
        return Ok();
    }

    // [HttpPost]
    // public async Task<ActionResult<PartyDTO>> AddUserToParty()
    // {
    //     throw new NotImplementedException();
    // }

    // [HttpPost]
    // public async Task<ActionResult<PartyDTO>> AddExpenseToParty()
    // {
    //     throw new NotImplementedException();
    // }

}