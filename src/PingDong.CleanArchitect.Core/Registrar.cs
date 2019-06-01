using MediatR;
using Microsoft.Extensions.DependencyInjection;
using PingDong.CleanArchitect.Service;

namespace PingDong.CleanArchitect.Core
{
    public class CoreRegistrar
    {
        public virtual void Register(IServiceCollection services)
        {
            // MediatR: Register all behaviors
            //    FluentValidation: 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehavior<,>));
        }
    }
}
