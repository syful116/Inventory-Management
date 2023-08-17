using InventoryManagement.Core;
using InventoryManagement.Infrastructure;
using InventoryManagement.Repositories.Base;
using InventoryManagement.Repositories.Interface;
using InvManagement.Model.Mapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using static System.Formats.Asn1.AsnWriter;

namespace InvManagement.IoC.Configuration;

public static class ConfigurationServices
{
    public static IServiceCollection AddExtention(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<InventoryDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("Conn")));



        services.AddTransient<ICustomerRepository, CustomerRepository>();

        services.AddAutoMapper(typeof(CommonMapper).Assembly);
        services.AddMediatR(options => options.RegisterServicesFromAssemblies(typeof(ICore).Assembly));
        return services;
    }


}
