using System.Data.Common;
using Npgsql;
using Sahari.Common.Application.Data;

namespace Sahari.Common.Infrastructure.Data;
internal sealed class DbConnectionFactory(NpgsqlDataSource dataSource) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync()
    {
        return await dataSource.OpenConnectionAsync();
    }
}
