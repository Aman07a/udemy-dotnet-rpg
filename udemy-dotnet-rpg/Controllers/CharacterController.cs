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
		private static Character knight = new Character();

		[HttpGet]
		public ActionResult<Character> Get()
		{
			return Ok(knight);
		}
	}
}
