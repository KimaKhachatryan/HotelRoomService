using System.ComponentModel.DataAnnotations;

namespace HotelRoomService.Core.Models.Entities
{
    public class Service
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 
       
        public string? Description { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
       
    }


}
