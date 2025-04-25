using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskPeak.Infrastructure.Data;

namespace TaskPeak.Infrastructure.Extension
{
    public static class ServiceCollection
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TaskPeakDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("TaskPeakDb")));

            services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<TaskPeakDbContext>();
        }
    }
}
