using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Resenhapp;

[ApiController]
public class GuestController: ControllerBase
{
    private readonly IMapper _mapper;
    public GuestController(IMapper mapper)
    {
        _mapper = mapper;
    }

    [HttpGet("[controller]")]
    public ActionResult<List<GuestDTO>> GetAll()
    {
        return Ok(Guest.guests.Select(guest => _mapper.Map<GuestDTO>(guest)));
    }

    [HttpGet("[controller]/{id}")]
    public ActionResult<GuestDTO> GetById([FromRoute] int id)
    {
        var guest = Guest.guests.Select(guest => guest.Id == id);
        return Ok(_mapper.Map<GuestDTO>(guest));
    }

    // [HttpPost("[controller]")]
    // public ActionResult<List<GuestDTO>> Add([FromBody] GuestDTO new_guest)
    // {
    //     var guest = _mapper.Map<Guest>(new_guest);
    //     Guest.guests.Add(guest);
    //     return Ok(Guest.guests.Select(guest => _mapper.Map<GuestDTO>(guest)));
    // }

    [HttpDelete("[controller]/{id}")]
    public ActionResult DeleteById([FromRoute] int id)
    {
        var guest = Guest.guests.FirstOrDefault(guest => guest.Id == id);
        if (guest == null) return NotFound();
        Guest.guests.Remove(guest);
        return Ok();
    }

    [HttpPut("[controller]")]
    public ActionResult<GuestDTO> Update([FromBody] GuestDTO updated_guest)
    {
        var guest = Guest.guests.FirstOrDefault(guest => guest.Id == updated_guest.Id);
        if (guest == null) return NotFound();
        guest = _mapper.Map<Guest>(updated_guest);
        return Ok();

    }

}