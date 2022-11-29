using _3dhi.Data.Entities;
using _3dhi.Models.ViewModels;
using AutoMapper;

namespace _3dhi.AutoMapperProfile
{
    public class ContactUsProfile : Profile
    {
        public ContactUsProfile()
        {
            CreateMap<ContactUsFormMessage, ContactUsMessageViewModel>()
                .ForMember(
                    dest => dest.SenderName,
                    opt => opt.MapFrom(src => $"{src.SenderName}")
                )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}")
                )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}")
                )
                .ForMember(
                    dest => dest.Message,
                    opt => opt.MapFrom(src => $"{src.Message}")
                )
                .ForMember(
                    dest => dest.PhoneNumber,
                    opt => opt.MapFrom(src => $"{src.PhoneNumber}")
                );


        }
    }


}
