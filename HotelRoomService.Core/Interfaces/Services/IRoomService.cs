using HotelRoomService.Core.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomService.Core.Interfaces.Services
{
    public interface IRoomService
    {
        Task<IEnumerable<RoomReadDto>> GetAllRoomsAsync();
        Task<RoomReadDto?> GetRoomByIdAsync(int id);
        Task AddRoomAsync(RoomCreateDto dto);
        Task UpdateRoomAsync(int id, RoomCreateDto dto);
        Task DeleteRoomAsync(int id);
        Task<RoomReadDto> BookRoomAsync(int roomId, int userId);
        Task<RoomReadDto> UnbookRoomAsync(int roomId, int userId);
    }
}
