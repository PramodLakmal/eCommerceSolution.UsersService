using eCommerce.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;



namespace eCommerce.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {

        services.AddTransient<IUsersRepository, UsersRepository>();

        services.AddTransient<DapperDbContext>();

        return services;
    }
}
