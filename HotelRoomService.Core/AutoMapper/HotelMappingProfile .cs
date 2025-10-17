using AutoMapper;
using HotelRoomService.Shared.DTO;
using HotelRoomService.Core.Models.Entities;
namespace HotelRoomService.Core.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserLoginDto, User>();
            CreateMap<Room, RoomReadDto>();
            CreateMap<RoomCreateDto, Room>();
            CreateMap<Service, ServiceReadDto>();
            CreateMap<ServiceCreateDto, Service>();
            CreateMap<ServiceBooking, ServiceBookingReadDto>();
            CreateMap<ServiceBookingCreateDto, ServiceBooking>();
        }
    }
}
