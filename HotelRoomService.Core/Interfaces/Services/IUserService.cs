using HotelRoomService.Shared.DTO;
namespace HotelRoomService.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserReadDto>> GetAllUsersAsync();
        Task<UserReadDto?> GetUserByIdAsync(int id);
        Task AddUserAsync(UserCreateDto dto);
        Task<UserReadDto?> LoginAsync(UserLoginDto dto);
    }
}
