using HotelRoomService.Core.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace HotelRoomService.Core.Models.Entities
{
    public class Room
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        public string Number { get; set; }
        public int Capacity { get; set; }
        public bool IsBooked { get; set; } = false;
        public int? BookedByUserId { get; set; }
        public DateTime? BookedAt { get; set; }
        public DateTime? UNbookedAt { get; set; }
        public RoomStatus Status { get; set; } = RoomStatus.Available;

    }

       
        /*
      Room
      Id(int, PK)
      Number(string, unique)
      Capacity(int)
      IsBooked(bool)
      BookedByUserId(nullable int, FK → User)
      BookedAt(nullable DateTime)
      UnbookedAt(nullable DateTime)
      Status(enum: "Available" | "Unavailable" | "Maintenance")
      */



    }
