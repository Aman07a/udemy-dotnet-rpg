namespace udemy_dotnet_rpg.Data
{
	public class AuthRepository : IAuthRepository
	{
		public Task<ServiceResponse<int>> Login(string username, string password)
		{
			throw new NotImplementedException();
		}

		public Task<ServiceResponse<int>> Register(User user, string password)
		{
			throw new NotImplementedException();
		}

		public Task<bool> UserExists(string username)
		{
			throw new NotImplementedException();
		}
	}
}
