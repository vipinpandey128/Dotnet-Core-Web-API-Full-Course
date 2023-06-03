using AutoMapper;
using StudentAdmission.DTOs;
using StudentAdmission.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdmission.MappingProfile
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<StudentSubjectDTO, StudentSubject>().ReverseMap();
            CreateMap<UserDTO, ApplicationUser>().ReverseMap();
                //.ForMember(x => x.Email, opt => opt.MapFrom(src => src.UserName))
                //.ForMember(x => x.FirstName, opt => opt.MapFrom(src => src.FirstName))
                //.ForMember(x => x.LastName, opt => opt.MapFrom(src => src.LastName))
                //.ForMember(x => x.PhoneNumber, opt => opt.MapFrom(src => src.Mobile))
                //.ForMember(x => x.Gender, opt => opt.MapFrom(src => src.Gender))
                //.ForMember(x => x.DOB, opt => opt.MapFrom(src => src.DOB));
                //.ReverseMap();
        }
    }
}
