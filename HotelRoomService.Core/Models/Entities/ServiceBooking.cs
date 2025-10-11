using HotelRoomService.Core.Models.Enums;

namespace HotelRoomService.Core.Models.Entities
{
    public class ServiceBooking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int? RoomId { get; set; } 
        public DateTime BookedAt { get; set; }
        public ServiceStatus Status { get; set; }
    }
    /*
     
    ServiceBooking
    Id(int, PK)
    UserId(FK → User)
    ServiceId(FK → Service)
    RoomId(nullable FK → Room, if service is tied to a room)
    BookedAt(DateTime)
     */

}
