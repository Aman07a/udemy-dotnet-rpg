﻿namespace udemy_dotnet_rpg.DTOS.Fight
{
	public class AttackResultDTO
	{
		public string Attacker { get; set; } = string.Empty;
		public string Opponent { get; set; } = string.Empty;
		public int AttackerHP { get; set; }
		public int OpponentHP { get; set; }
		public int Damage { get; set; }
	}
}
