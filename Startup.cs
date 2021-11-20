using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection
{
    /* Created a static class named Startup and installed a Nuget Package
     * called Microsoft.Extensions.DependencyInjection
     * In this class, I created a method called ConfigureServices() which
     * returns IServiceProvider
     */
    internal class Startup
    {
        public static IServiceProvider ConfigureServices()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IFooService, FooService>()
                .AddSingleton<IBarService, BarService>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
