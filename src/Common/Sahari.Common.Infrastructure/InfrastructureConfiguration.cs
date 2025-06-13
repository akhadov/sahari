using Dapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Npgsql;
using Sahari.Common.Application.Clock;
using Sahari.Common.Application.Data;
using Sahari.Common.Infrastructure.Authentication;
using Sahari.Common.Infrastructure.Authorization;
using Sahari.Common.Infrastructure.Clock;
using Sahari.Common.Infrastructure.Data;

namespace Sahari.Common.Infrastructure;
public static class InfrastructureConfiguration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        string serviceName,
        string databaseConnectionString,
        string redisConnectionString)
    {
        services.AddAuthenticationInternal();

        services.AddAuthorizationInternal();

        services.TryAddSingleton<IDateTimeProvider, DateTimeProvider>();

        NpgsqlDataSource npgsqlDataSource = new NpgsqlDataSourceBuilder(databaseConnectionString).Build();
        services.TryAddSingleton(npgsqlDataSource);

        services.TryAddScoped<IDbConnectionFactory, IDbConnectionFactory>();

        SqlMapper.AddTypeHandler(new GenericArrayHandler<string>());

        return services;
    }
}
