namespace HotelRoomService.Shared.DTO
{
    public class ServiceBookingCreateDto
    {
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int? RoomId { get; set; }
    }
}
