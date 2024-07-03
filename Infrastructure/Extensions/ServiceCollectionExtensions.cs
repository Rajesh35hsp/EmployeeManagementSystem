using Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<EmsDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("EmpDbConnectionString"));
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }

    }
}
