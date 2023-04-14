using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Infra.Data.Repository;
using ClearnArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //application layer
            services.AddScoped<ICourseService, CourseService>();

            //infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
