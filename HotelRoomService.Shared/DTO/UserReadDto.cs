using HotelRoomService.Shared.Enums;
namespace HotelRoomService.Shared.DTO
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
    }
}
