using System.Linq;
using AutoMapper;
using DatingApp.API.DTOs;
using DatingApp.API.Models;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User,UserForListDTO>()
            .ForMember(dest =>dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.isMain).Url);
            })
            .ForMember(dest => dest.Age, opt =>{
                opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<User,UserForDetailsDTO>()
            .ForMember(dest =>dest.PhotoUrl, opt => {
                opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.isMain).Url);
            })
            .ForMember(dest => dest.Age, opt =>{
                opt.ResolveUsing(d => d.DateOfBirth.CalculateAge());
            });
            CreateMap<Photo,PhotosForDetailsDTO>();
            CreateMap<UserForUpdateDTO,User>();
            CreateMap<Photo,PhotoForReturnDTO>();
            CreateMap<PhotoForCreationDTO,Photo>();
            CreateMap<UserForRegisterDTO,User>();
            CreateMap<MessageForCreationDTO,Message>().ReverseMap();
            CreateMap<Message,MessageToReturnDTO>()
            .ForMember(m => m.SenderPhotoUrl, opt => opt.MapFrom(u => u.Sender.Photos.FirstOrDefault(p =>p.isMain).Url))
            .ForMember(m => m.RecipientPhotoUrl, opt => opt.MapFrom(u => u.Recipient.Photos.FirstOrDefault(p =>p.isMain).Url));
        }
                
        }
}