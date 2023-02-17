using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using udemy_dotnet_rpg.DTOS.Character;
using udemy_dotnet_rpg.DTOS.Weapon;

namespace udemy_dotnet_rpg.Services.WeaponService
{
	public class WeaponService : IWeaponService
	{
		private readonly DataContext _context;
		private readonly IHttpContextAccessor _httpContextAccessor;
		private readonly IMapper _mapper;

		public WeaponService(DataContext context, IHttpContextAccessor httpContextAccessor, IMapper mapper)
		{
			_httpContextAccessor = httpContextAccessor;
			_mapper = mapper;
			_context = context;
		}

		public async Task<ServiceResponse<GetCharacterDTO>> AddWeapon(AddWeaponDTO newWeapon)
		{
			var response = new ServiceResponse<GetCharacterDTO>();

			try
			{
				var character = await _context.Characters.FirstOrDefaultAsync(c => c.Id == newWeapon.CharacterId);


				if (character is null)
				{
					response.Success = false;
					response.Message = "Character not found.";
					return response;
				}

				var weapon = new Weapon
				{
					Name = newWeapon.Name,
					Damage = newWeapon.Damage,
					Character = character
				};

				_context.Weapons.Add(weapon);
				await _context.SaveChangesAsync();

				response.Data = _mapper.Map<GetCharacterDTO>(character);
			}
			catch (Exception ex)
			{
				response.Success = false;
				response.Message = ex.Message;
			}

			return response;
		}
	}
}
