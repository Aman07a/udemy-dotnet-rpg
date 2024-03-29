﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_dotnet_rpg.DTOS.Fight;
using udemy_dotnet_rpg.DTOS.Skill;
using udemy_dotnet_rpg.DTOS.Weapon;

namespace udemy_dotnet_rpg
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Character, GetCharacterDTO>();
			CreateMap<AddCharacterDTO, Character>();
			CreateMap<Weapon, GetWeaponDTO>();
			CreateMap<Skill, GetSkillDTO>();
			CreateMap<Character, HighscoreDTO>();
		}
	}
}
