using System.Data.Common;

namespace Sahari.Common.Application.Data;
public interface IDbConnectionFactory
{
    ValueTask<DbConnection> OpenConnectionAsync();
}
