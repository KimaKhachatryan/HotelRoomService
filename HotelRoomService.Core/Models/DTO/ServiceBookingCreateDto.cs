using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomService.Core.Models.DTO
{
    public class ServiceBookingCreateDto
    {
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public int? RoomId { get; set; }
    }
}
