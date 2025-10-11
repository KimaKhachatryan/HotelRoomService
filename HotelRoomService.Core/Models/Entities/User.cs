using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HotelRoomService.Core.Models.Enums;

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



        /*User
   Id(int, PK)
   Name(string, required)
   Email(string, unique)
   PasswordHash(string)
   Role(enum: "User" | "Manager")*/

    }


}
