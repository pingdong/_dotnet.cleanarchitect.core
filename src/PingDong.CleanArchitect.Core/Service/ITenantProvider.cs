namespace PingDong.CleanArchitect.Service
{
    public interface ITenantProvider<out T>
    {
        T GetTenantId();
    }
}
