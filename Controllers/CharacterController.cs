using System.Collections.Generic;
using dotnet31_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet31_rpg.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class CharacterController : ControllerBase
  {
    private static List<Character> characters = new List<Character> {
      new Character(),
      new Character { Id = 1, Name = "Sam" }
    };

    public IActionResult Get()
    {
      return Ok(characters);
    }

    [HttpGet("{id}")]
    public IActionResult GetSingle(int id)
    {
      return Ok(characters.Find(c => c.Id == id));
    }
  }
}