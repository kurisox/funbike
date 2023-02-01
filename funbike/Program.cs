using Autofac;
using funbike.DependencyInjectionConfigs;

namespace funbike
{
    public class Program
    {
        static void Main(string[] args) {        
            var container = SimpleContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope()){
                var app = scope.Resolve<IApplication>();
                app.run();
            }

        }
    }
}