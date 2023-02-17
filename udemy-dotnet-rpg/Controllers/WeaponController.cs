using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using udemy_dotnet_rpg.DTOS.Character;
using udemy_dotnet_rpg.DTOS.Weapon;
using udemy_dotnet_rpg.Services.WeaponService;

namespace udemy_dotnet_rpg.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WeaponController : ControllerBase
	{
		private readonly IWeaponService _weaponService;

		public WeaponController(IWeaponService weaponService)
		{
			_weaponService = weaponService;
		}

		[HttpPost]
		public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> AddWeapon(AddWeaponDTO newWeapon)
		{
			return Ok(await _weaponService.AddWeapon(newWeapon));
		}
	}
}
