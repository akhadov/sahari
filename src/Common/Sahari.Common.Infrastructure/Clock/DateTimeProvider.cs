using Sahari.Common.Application.Clock;

namespace Sahari.Common.Infrastructure.Clock;
internal sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
