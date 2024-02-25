using Business.Abstracts;
using Business.Concretes;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessService(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICourseService, CourseManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        return services;
    }
}
