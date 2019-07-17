using System;

namespace PingDong.CleanArchitect.Service
{
    public interface ITenantProvider
    {
        Guid GetTenantId();
    }
}
