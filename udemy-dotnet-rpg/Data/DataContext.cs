﻿namespace udemy_dotnet_rpg.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<Character> Characters => Set<Character>();
		public DbSet<User> Users => Set<User>();
		public DbSet<Weapon> Weapons => Set<Weapon>();
	}
}
