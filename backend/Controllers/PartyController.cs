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
    {;
        await _dbservice.Create(party);
        return Ok();
    }

    [HttpPost("{id}/new_guest")]
    public async Task<ActionResult<PartyDTO>> AddGuest([FromRoute] int id, [FromBody] GuestDTO guest)
    {
        await _dbservice.AddGuest(id, guest);
        var party = await _dbservice.GetById(id);
        return Ok(party);
    }

    [HttpPost("{id}/new_expense")]
    public async Task<ActionResult<PartyDTO>> AddExpense([FromRoute] int id, [FromBody] ExpenseDTO expense)
    {
        await _dbservice.AddExpense(id, expense);
        var party = await _dbservice.GetById(id);
        return Ok(party);
    }

}