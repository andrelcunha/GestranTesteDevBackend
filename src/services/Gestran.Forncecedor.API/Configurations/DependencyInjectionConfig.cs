using Gestran.Forncecedor.API.Data;

namespace Gestran.Forncecedor.API.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<ContextoPrincipal>();
        }
    }
}
