using HotelRoomService.Core.Models.Enums;
namespace HotelRoomService.Core.Models.DTO
{
    public class ServiceBookingReadDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int? RoomId { get; set; }
        public DateTime BookedAt { get; set; }
        public ServiceStatus Status { get; set; }
    }
}
