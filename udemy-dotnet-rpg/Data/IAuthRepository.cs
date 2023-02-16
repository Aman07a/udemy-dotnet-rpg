namespace udemy_dotnet_rpg.Data
{
	public interface IAuthRepository
	{
		Task<ServiceResponse<int>> Register(User user, string password);
		Task<ServiceResponse<int>> Login(string username, string password);
		Task<bool> UserExists(string username);
	}
}
