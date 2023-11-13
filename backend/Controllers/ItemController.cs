using AutoMapper;
using Microsoft.AspNetCore.Http.Features;
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
    private readonly IMapper _mapper;
    public ItemController(IItemService service, IMapper mapper)
    {
        _dbservice = service;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<List<ItemDTO>>> GetAll()
    {
        var items = await _dbservice.GetAll();
        return Ok(_mapper.Map<List<ItemDTO>>(items));
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<ItemDTO>> GetById([FromRoute] int id)
    {
        var item = await _dbservice.GetById(id);
        if (item == null) return NotFound();
        var itemdto = _mapper.Map<ItemDTO>(item);
        return Ok(itemdto);
    }

    [HttpPost]
    public async Task<ActionResult<List<ItemDTO>>> Add([FromBody]ItemDTO new_item)
    {
        var item = _mapper.Map<Item>(new_item);
        await _dbservice.Create(item);
       
        var items = await _dbservice.GetAll();
        return Ok(_mapper.Map<List<ItemDTO>>(items));
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<List<ItemDTO>>> DeleteById([FromRoute]int id)
    {
        var item = await _dbservice.GetById(id);
        if (item == null) return NotFound();
        await _dbservice.Delete(item);
        var items = await _dbservice.GetAll();
        return Ok(_mapper.Map<List<ItemDTO>>(items));
    }

    [HttpPut]
    public async Task<ActionResult<ItemDTO>> Update([FromBody]ItemDTO updated_item)
    {
        await _dbservice.Update(updated_item);
        return Ok(await _dbservice.GetById(updated_item.Id));
    }
}
