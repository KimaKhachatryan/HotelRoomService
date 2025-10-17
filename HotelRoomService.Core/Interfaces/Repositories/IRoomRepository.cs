using HotelRoomService.Core.Models.Entities;

namespace HotelRoomService.Core.Interfaces.Repositories
{
    public interface IRoomRepository : IGenericRepository<Room>
    {
        Task<IEnumerable<Room>> GetAvailableRoomsAsync(DateTime startDate, DateTime endDate);
    }
}
