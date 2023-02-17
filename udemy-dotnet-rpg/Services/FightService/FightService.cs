﻿using udemy_dotnet_rpg.DTOS.Fight;

namespace udemy_dotnet_rpg.Services.FightService
{
	public class FightService : IFightService
	{
		private readonly DataContext _context;

		public FightService(DataContext context)
		{
			_context = context;
		}

		public async Task<ServiceResponse<AttackResultDTO>> WeaponAttack(WeaponAttackDTO request)
		{
			var response = new ServiceResponse<AttackResultDTO>();

			try
			{
				var attacker = await _context.Characters
					.Include(c => c.Weapon)
					.FirstOrDefaultAsync(c => c.Id == request.AttackerId);

				var opponent = await _context.Characters
					.FirstOrDefaultAsync(c => c.Id == request.OpponentId);

				if (attacker is null || opponent is null || attacker.Weapon is null)
					throw new Exception("Something fishy is going on here...");

				int damage = attacker.Weapon.Damage + (new Random().Next(attacker.Strength));
				damage -= new Random().Next(opponent.Defeats);

				if (damage > 0)
					opponent.HitPoints -= damage;

				if (opponent.HitPoints <= 0)
					response.Message = $"{opponent.Name} has been defeated!";

				await _context.SaveChangesAsync();

				response.Data = new AttackResultDTO
				{
					Attacker = attacker.Name,
					Opponent = opponent.Name,
					AttackerHP = attacker.HitPoints,
					OpponentHP = opponent.HitPoints,
					Damage = damage
				};
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