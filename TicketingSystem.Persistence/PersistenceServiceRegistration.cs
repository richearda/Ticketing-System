using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.Application.Contracts.Persistence;
using TicketingSystem.Persistence.Repositories;

namespace TicketingSystem.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<TicketingSystemDBContext>(options => options.UseSqlServer(configuration.GetConnectionString("TicketingSystemConnection")));

            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<ICostCenterRepository, CostCenterRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISystemInfoRepository, SystemInfoRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();


            return services;
        }
    }
}
