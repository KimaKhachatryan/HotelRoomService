using HotelRoomService.Core.Models.Entities;

namespace HotelRoomService.Core.Interfaces.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
        {
            Task<User> GetByEmailAsync(string email);
        }
    
}
