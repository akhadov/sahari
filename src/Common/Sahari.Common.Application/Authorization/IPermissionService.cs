using Sahari.Common.Domain;

namespace Sahari.Common.Application.Authorization;
public interface IPermissionService
{
    Task<Result<PermissionsResponse>> GetUserPermissionsAsync(string identityId);
}

