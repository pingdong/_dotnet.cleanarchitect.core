namespace PingDong.CleanArchitect.Service
{
    public interface ITenantValidator<in T>
    {
        bool IsValid(T tenantId);
    }
}
