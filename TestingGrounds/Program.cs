using System;
using HessianFramework;
using Microsoft.Extensions.DependencyInjection;
using PostGresInterface;

namespace TestingGrounds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient(typeof(IDataBase), typeof(PostGresConnection));

            
            var app = new App(serviceCollection);
            app.Run();
        }
        

        public class App
        {
            public IServiceProvider Services { get; set; }

            private ContentAndAssetHandler AssetHandler { get; set; }
            public App(IServiceCollection servicecollection)
            {
                Services = servicecollection.BuildServiceProvider();
            }

            public void Run()
            {
                AssetHandler = new ContentAndAssetHandler(Services.GetService<IDataBase>());
                var d = 9;
            }

        }
    }
}
