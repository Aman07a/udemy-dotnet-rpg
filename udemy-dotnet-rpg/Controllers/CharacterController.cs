using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace udemy_dotnet_rpg.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CharacterController : ControllerBase
	{
		private readonly ICharacterService _characterService;

		public CharacterController(ICharacterService characterService)
		{
			_characterService = characterService;
		}

		[HttpGet("GetAll")]
		public ActionResult<List<Character>> Get()
		{
			return Ok(_characterService.GetAllCharacters());
		}

		[HttpGet("{id}")]
		public ActionResult<Character> GetSingle(int id)
		{
			return Ok(_characterService.GetCharacterById(id));
		}

		[HttpPost]
		public ActionResult<List<Character>> AddCharacter(Character newCharacter)
		{
			return Ok(_characterService.AddCharacter(newCharacter));
		}
	}
}
