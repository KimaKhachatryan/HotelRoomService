using HotelRoomService.Shared;
using HotelRoomService.Shared.DTO;
namespace HotelRoomService.Core.Interfaces
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
