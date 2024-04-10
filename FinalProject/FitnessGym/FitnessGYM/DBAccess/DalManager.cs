using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Dalapi;
using Dal.DalImplementation;
using Dal.Do;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalManager
    {
        public ICourses courses {  get; set; }  
        public ISchedule schedule { get; set; }
        public ISubscriber subscriber { get; set; }
        public ITeacher teacher { get; set; }
        public DalManager() {
            ServiceCollection services = new ServiceCollection();
            services.AddSingleton<LibraryContext>();
            services.AddScoped<ICourses, CoursesRepo>();
            services.AddScoped<ISchedule, ScheduleRepo>();
            services.AddScoped<ISubscriber, SubscriberRepo>();
            services.AddScoped<ITeacher, TeacherRepo>();

            ServiceProvider servicesProvider = services.BuildServiceProvider();

            courses = servicesProvider.GetRequiredService<ICourses>();
            schedule = servicesProvider.GetRequiredService<ISchedule>();
            subscriber = servicesProvider.GetRequiredService<ISubscriber>();
            teacher = servicesProvider.GetRequiredService<ITeacher>();

        } 
    }
}
