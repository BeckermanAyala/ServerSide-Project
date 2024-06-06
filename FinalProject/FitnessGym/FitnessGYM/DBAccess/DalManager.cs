using Dal.Dalapi;
using Dal.DalImplementation;
using Dal.Do;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Dal
{
    public class DalManager
    {
        public ICourses courses { get; set; }
        public ISchedule schedule { get; set; }
        public ISubscriber subscriber { get; set; }
        public ITeacher teacher { get; set; }
        private readonly ServiceProvider serviceProvider;

        public DalManager(string connectionString)
        {
            var services = new ServiceCollection();
            services.AddDbContext<LibraryContext>(options =>options.UseSqlServer(connectionString));
                

            services.AddScoped<ICourses, CoursesRepo>();
            services.AddScoped<ISchedule, ScheduleRepo>();
            services.AddScoped<ISubscriber, SubscriberRepo>();
            services.AddScoped<ITeacher, TeacherRepo>();

            serviceProvider = services.BuildServiceProvider();

            courses = serviceProvider.GetRequiredService<ICourses>();
            schedule = serviceProvider.GetRequiredService<ISchedule>();
            subscriber = serviceProvider.GetRequiredService<ISubscriber>();
            teacher = serviceProvider.GetRequiredService<ITeacher>();
        }
    }
}
