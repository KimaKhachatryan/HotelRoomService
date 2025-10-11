using HotelRoomService.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomService.Core.Models.DTO
{
    public class RoomCreateDto
    {
        public string Number { get; set; }
        public int Capacity { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Available;
    }
}
