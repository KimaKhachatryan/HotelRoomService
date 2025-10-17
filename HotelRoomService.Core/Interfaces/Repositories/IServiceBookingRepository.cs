using HotelRoomService.Core.Models.Entities;

namespace HotelRoomService.Core.Interfaces.Repositories
{
    public interface IServiceBookingRepository : IGenericRepository<ServiceBooking>
    {
        Task<IEnumerable<ServiceBooking>> GetByUserIdAsync(int userId);
    }
}
}
