using udemy_dotnet_rpg.DTOS.Fight;

namespace udemy_dotnet_rpg.Services.FightService
{
	public interface IFightService
	{
		Task<ServiceResponse<AttackResultDTO>> WeaponAttack(WeaponAttackDTO request);
	}
}
