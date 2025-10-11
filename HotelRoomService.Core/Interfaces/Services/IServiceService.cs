using HotelRoomService.Core.Models.DTO;

namespace HotelRoomService.Core.Interfaces.Services
{
    public interface IServiceService
    {
        Task<IEnumerable<ServiceReadDto>> GetAllServicesAsync();
        Task<ServiceReadDto?> GetServiceByIdAsync(int id);
        Task AddServiceAsync(ServiceCreateDto dto);
        Task UpdateServiceAsync(int id, ServiceCreateDto dto);
        Task DeleteServiceAsync(int id);
    }
}
