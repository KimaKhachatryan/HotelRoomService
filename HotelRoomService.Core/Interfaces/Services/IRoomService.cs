using HotelRoomService.Shared.DTO;
namespace HotelRoomService.Core.Interfaces.Services
{
    public interface IRoomService
    {
        Task AddRoomAsync(RoomCreateDto dto);
        Task UpdateRoomAsync(int id, RoomCreateDto dto);
        Task DeleteRoomAsync(int id);
    }
}
