using Gestran.Forncecedor.API.Configurations;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddApiConfiguration(builder.Configuration);

        builder.Services.AddSwaggerConfiguration();

        builder.Services.RegisterServices();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.UseApiConfiguration(app.Environment);

        app.MapControllers();

        app.Run();
    }
}