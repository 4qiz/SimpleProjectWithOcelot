
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace OcelotGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //ocelot
            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
            builder.Services.AddOcelot(builder.Configuration)
                .AddCacheManager(o =>
                {
                    o.WithDictionaryHandle();
                });

            var app = builder.Build();

            app.UseAuthorization();

            app.MapControllers();

            // ocelot
            app.UseOcelot();

            app.Run();
        }
    }
}
