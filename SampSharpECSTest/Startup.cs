using Microsoft.Extensions.DependencyInjection;
using SampSharp.Entities;
using SampSharp.Entities.SAMP;

namespace SampSharpECSTest
{
    public class Startup : IStartup
    {
        public void Configure(IServiceCollection services)
        {
            // TODO: Add services and systems to the services collection

            services.AddSystem<MyFirstSystem>();
        }

        public void Configure(IEcsBuilder builder)
        {
            // TODO: Enable desired ECS system features

            builder.EnableSampEvents()
                .EnablePlayerCommands()
                .EnableRconCommands();
        }
    }
}