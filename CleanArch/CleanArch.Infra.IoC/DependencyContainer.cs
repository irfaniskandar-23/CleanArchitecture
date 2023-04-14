using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Core.Bus;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using ClearnArch.Domain.CommandHandlers;
using ClearnArch.Domain.Commands;
using ClearnArch.Domain.Interfaces;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBust MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();


            //Domain Hanlders

            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //application layer
            services.AddScoped<ICourseService, CourseService>();

            //infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();


            services.AddScoped<UniversityDBContext>();
        }
    }
}
