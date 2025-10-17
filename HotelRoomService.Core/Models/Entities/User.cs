using System.ComponentModel.DataAnnotations;
using HotelRoomService.Shared.Enums;

namespace HotelRoomService.Core.Models.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }
        [Required, EmailAddress,MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public string PasswordHash { get;set; }
        
        public UserRole Role { get; set; }



     

    }


}
