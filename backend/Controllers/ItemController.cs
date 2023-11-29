using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using Resenhapp.Repositories.DTOs;
using Resenhapp.Repositories.Models;
using Resenhapp.Services.Interfaces;

namespace Resenhapp.Controllers;

[Route("api/[controller]/")]
[ApiController]
public class ItemController: ControllerBase
{
    private readonly IItemService _dbservice;
    public ItemController(IItemService service, IMapper mapper)
    {
        _dbservice = service;
    }

    [HttpGet]
    public async Task<ActionResult<List<ItemDTO>>> GetAll()
    {
        return Ok(await _dbservice.GetAll());
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<ItemDTO>> GetById([FromRoute] int id)
    {
        var item = await _dbservice.GetById(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost]
    public async Task<ActionResult<List<ItemDTO>>> Add([FromBody]ItemDTO item)
    {
        await _dbservice.Create(item);  
        return Ok(await _dbservice.GetAll());
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<ItemDTO>>> DeleteById([FromRoute]int id)
    {
        try{await _dbservice.DeleteById(id);}
        catch (Exception){return NotFound();}
        return Ok(await _dbservice.GetAll());
    }

    [HttpPut]
    public async Task<ActionResult<ItemDTO>> Update([FromBody]ItemDTO updated_item)
    {
        await _dbservice.Update(updated_item);
        return Ok(await _dbservice.GetById(updated_item.Id));
    }
}
