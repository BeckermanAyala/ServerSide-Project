using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL.BLlmplementaiton;
using BL.BLapi;
using BL.Bo;
using Microsoft.Extensions.DependencyInjection;







namespace BL
{
    public class BLManager
    {
        public IFullCoursesRepo fullCourses { get; }
        public IFullScheduleRepo fullSchedule { get; }
        public IFullTeacherRepo fullTeacher { get; }
        public IPersonalCoursesRepo personalCourses { get; set; }
        public IPersonalSchduleRepo personalSchdule { get; }
        public IPersonalSubscriberRepo personalSubscriber { get; }
        public IPersonalTeacherRepo PersonalTeacher { get; }

        public BLManager()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<DalManager>();
            services.AddScoped<IFullCoursesRepo, FullCoursesRepo>();  
            services.AddScoped<IFullScheduleRepo, FullScheduleRepo>();
            services.AddScoped<IFullTeacherRepo, FullTeacherRepo>();
            services.AddScoped<IPersonalCoursesRepo, PersonalCoursesRepo>();
            services.AddScoped<IPersonalSchduleRepo, PersonalSchduleRepo>();
            services.AddScoped<IPersonalSubscriberRepo, PersonalSubscriberRepo>();
            services.AddScoped<IPersonalTeacherRepo, PersonalTeacherRepo>();

            ServiceProvider provider = services.BuildServiceProvider();

            fullCourses = provider.GetRequiredService<IFullCoursesRepo>();
            fullCourses = provider.GetRequiredService<IFullScheduleRepo>();

            fullCourses = provider.GetRequiredService<IFullTeacherRepo>();

            fullCourses = provider.GetRequiredService<IPersonalCoursesRepo>();

            fullCourses = provider.GetRequiredService<IPersonalSchduleRepo>();
            fullCourses = provider.GetRequiredService<IPersonalSubscriberRepo>();
            fullCourses = provider.GetRequiredService<IPersonalTeacherRepo>();


        }

    }
}
