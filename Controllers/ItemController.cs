using Microsoft.AspNetCore.Mvc;

namespace Resenhapp.Controllers;

[ApiController]
public class ItemController: ControllerBase
{
    [HttpGet("[controller]s")]
    public IActionResult GetAll() => Ok(Item.items.ToList());
    
    [HttpGet("[controller]/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var item = Item.items.FirstOrDefault(x => x.Id == id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    [HttpPost("[controller]")]
    public IActionResult Add([FromBody]Item obj)
    {
        var item = new Item {
            Id = obj.Id,
            Name = obj.Name,
            Price = obj.Price,
            Description = obj.Description
        };
        Item.items.Add(item);
        return NoContent();
    }
    
    [HttpDelete("[controller]/{id}")]
    public IActionResult DeleteById([FromRoute]int id)
    {
        var item = Item.items.FirstOrDefault(x => x.Id == id);
        if (item == null) return NotFound();
        Item.items.Remove(item);
        return Ok();
    }

    [HttpPut("[controller]")]
    public IActionResult Update([FromBody]Item obj)
    {
        var item = Item.items.FirstOrDefault(x => x.Id == obj.Id);
        if (item == null) return NotFound();
        item.Name = obj.Name;
        item.Price = obj.Price;
        item.Description = obj.Description;
        return Ok(); 
    }
}
