﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_dotnet_rpg.DTOS.Character;

namespace udemy_dotnet_rpg.Services.CharacterService
{
	public interface ICharacterService
	{
		Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters(int userId);
		Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
		Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);
		Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updatedCharacter);
		Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id);
	}
}
