using BL.BLapi;
using BL.BLlmplementaiton;
using Dal;
using Microsoft.Extensions.DependencyInjection;

namespace BL
{
    public class BLManager
    {
        public IFullCoursesRepo fullCourses { get; }
        public IFullScheduleRepo fullSchedule { get; }
        public IFullTeacherRepo fullTeacher { get; }
        public IPersonalCoursesRepo personalCourses { get; }
        public IPersonalSchduleRepo personalSchdule { get; }
        public IPersonalSubscriberRepo personalSubscriber { get; }
        public IPersonalTeacherRepo personalTeacher { get; }
        private readonly ServiceProvider serviceProvider;

        public BLManager(string connectionString)
        {
            var services = new ServiceCollection();

            services.AddSingleton<DalManager>(sp => new DalManager(connectionString));
            services.AddScoped<IFullCoursesRepo, FullCoursesRepo>();
            services.AddScoped<IFullScheduleRepo, FullScheduleRepo>();
            services.AddScoped<IFullTeacherRepo, FullTeacherRepo>();
            services.AddScoped<IPersonalCoursesRepo, PersonalCoursesRepo>();
            services.AddScoped<IPersonalSchduleRepo, PersonalSchduleRepo>();
            services.AddScoped<IPersonalSubscriberRepo, PersonalSubscriberRepo>();
            services.AddScoped<IPersonalTeacherRepo, PersonalTeacherRepo>();
            services.AddAutoMapper(typeof(AutoMapper.AutoMapperProfile));

            serviceProvider = services.BuildServiceProvider();

            fullCourses = serviceProvider.GetRequiredService<IFullCoursesRepo>();
            fullSchedule = serviceProvider.GetRequiredService<IFullScheduleRepo>();
            fullTeacher = serviceProvider.GetRequiredService<IFullTeacherRepo>();
            personalCourses = serviceProvider.GetRequiredService<IPersonalCoursesRepo>();
            personalSchdule = serviceProvider.GetRequiredService<IPersonalSchduleRepo>();
            personalSubscriber = serviceProvider.GetRequiredService<IPersonalSubscriberRepo>();
            personalTeacher = serviceProvider.GetRequiredService<IPersonalTeacherRepo>();
        }
    }
}
