using HotelRoomService.Shared.DTO;

namespace HotelRoomService.Core.Interfaces.Services
{
    public interface IServiceBookingService
    {
        Task<IEnumerable<ServiceBookingReadDto>> GetAllBookingsAsync();
        Task<ServiceBookingReadDto?> GetBookingByIdAsync(int id);
        Task<IEnumerable<ServiceBookingReadDto>> GetBookingsByUserIdAsync(int userId);
        Task<ServiceBookingReadDto> BookServiceAsync(ServiceBookingCreateDto dto);
        Task<ServiceBookingReadDto> UnbookServiceAsync(int bookingId, int userId);
    }
}
