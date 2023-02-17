using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_dotnet_rpg.DTOS.Character;
using udemy_dotnet_rpg.DTOS.Weapon;

namespace udemy_dotnet_rpg.Services.WeaponService
{
	public interface IWeaponService
	{
		Task<ServiceResponse<GetCharacterDTO>> AddWeapon(AddWeaponDTO newWeapon);
	}
}
