using HotelRoomService.Shared.Enums;
namespace  HotelRoomService.Shared.DTO

{
    public class RoomCreateDto
    {
        public string Number { get; set; }
        public int Capacity { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Available;
    }
}
