namespace BlazorDemoApp.Infrastructures
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Data;

    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder  PrepareDatabase(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            MigrateDatabase(services);

            return app;
        }

        private static void MigrateDatabase(IServiceProvider services)
        {
            var db = services.GetRequiredService<ApplicationDbContext>();
            db.Database.Migrate();
        }
    }
}
