using Microsoft.OpenApi.Models;
using System.Xml.Linq;
using System;

namespace Gestran.Forncecedor.API.Configurations
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Gestran API Fornecedor",
                    Version = "v1",
                    Description = "Essa API faz parte do teste da Gestran para Desenvedor backend e fornece o cadastro de fornecedores",
                    Contact = new OpenApiContact
                    {
                        Name = "André Luís da Cunha",
                        Email = "andre.l.cunha@live.com",
                        Url = new Uri("https://github.com/andrelcunha")
                    },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");

            });
            return app;
        }
    }
}
