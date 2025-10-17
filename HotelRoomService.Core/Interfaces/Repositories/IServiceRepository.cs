using HotelRoomService.Core.Models.Entities;

namespace HotelRoomService.Core.Interfaces.Repositories
{
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Task<IEnumerable<Service>> GetByNameAsync(string name);
    }
}
