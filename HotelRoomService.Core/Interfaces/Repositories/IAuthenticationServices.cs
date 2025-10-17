namespace HotelRoomService.Core.Interfaces.Repositories
{
    public interface IAuthenticationServices
    {
        Task<bool> ValidateTokenAsync(string token);
        Task RegisterUserAsync(string email, string password, string name);
    }
}
