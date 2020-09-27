using CleanArch.Application.Services;
using CleanArch.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ClainArch.Infra.Data.Repository;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data LAyer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
    }
}
