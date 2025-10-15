using HotelRoomService.Shared.Enums;
namespace HotelRoomService.Shared.DTO
{
    public class RoomReadDto
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int Capacity { get; set; }
        public bool IsBooked { get; set; }
        public RoomStatus Status { get; set; }
    }
}
