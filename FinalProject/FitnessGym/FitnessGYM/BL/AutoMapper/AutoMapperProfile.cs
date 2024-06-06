using AutoMapper;
using BL.Bo;
using Dal.Do;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<FullCourses, Dal.Do.Course>()
           //.ForMember(dest => dest.CodeCourse, opt => opt.MapFrom(src => GetCodeCourse(src)))
           //.ForMember(dest => dest.MaxParticipants, opt => opt.MapFrom(src => GetMaxParticipants(src)))
           .ReverseMap();

            CreateMap<PersonalSubscriber, Dal.Do.Subscriber>()
           //.ForMember(dest => dest.SubscriberId, opt => opt.MapFrom(src => GetSubscriberId(src)))
           //.ForMember(dest => dest.Password, opt => opt.MapFrom(src => GetPassword(src)))
           .ReverseMap();

            CreateMap<Schedule, Dal.Do.Schedule>()
           .ForMember(dest => dest.CodeSchedule, opt => opt.MapFrom(src => GetCodeSchedule(src)))
           .ForMember(dest => dest.CodeCourse, opt => opt.MapFrom(src => GetCodeCourse2(src)))
           .ReverseMap();

            CreateMap<FullTeacher, Dal.Do.Teacher>()
           //.ForMember(dest => dest.TeachersId, opt => opt.MapFrom(src => GetTeachersId(src)))
           .ReverseMap();

        }
        private string GetCodeCourse(Course course)
        {
            return "Unknown";
        }
        private int GetMaxParticipants(Course course)
        {
            return 30;
        }
        private string GetSubscriberId(Subscriber subscriber)
        {
            return "Unknown";
        }
        private string GetPassword(Subscriber subscriber)
        {
            return "Unknown";
        }
        private string GetCodeSchedule(Schedule schedule)
        {
            return "Unknown";
        }
        private string GetCodeCourse2(Schedule schedule)
        {
            return "Unknown";
        }
        private string GetTeachersId(Teacher teacher)
        {
            return "Unknown";
        }
    }
}
