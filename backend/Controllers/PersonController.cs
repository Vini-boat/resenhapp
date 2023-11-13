// using AutoMapper;
// using Microsoft.AspNetCore.Mvc;

// namespace Resenhapp.Controllers;

// [ApiController]
// public class PersonController: ControllerBase
// {
//     private readonly IMapper _mapper;
//     public PersonController(IMapper mapper)
//     {
//         _mapper = mapper;
//     }

//     [HttpGet("[controller]s")]
//     public IActionResult GetAll() => Ok(Person.persons.ToList());

//     [HttpGet("[controller]/{id}")]
//     public IActionResult GetById([FromRoute] int id)
//     {
//         var person = Person.persons.FirstOrDefault(x => x.Id == id);
//         if (person == null) return NotFound();
//         return Ok(person);
//     }

//     [HttpPost("[controller]")]
//     public IActionResult Add([FromBody] Person obj)
//     {
//         var person = new Person {
//             Id = obj.Id,
//             Name = obj.Name,
//             Age = obj.Age,
//             Instagram = obj.Instagram,
//             Gender = obj.Gender,
//             Partner = obj.Partner,
//             SexualPreference = obj.SexualPreference
//         };
//         Person.persons.Add(person);
//         return Ok();
//     }

// }