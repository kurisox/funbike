using Library;
using Library.classes.DataInput;
using Library.classes.Offer;
using Library.classes.Calculation;
using Library.classes.GUI;
using Autofac;

namespace funbike
{
    public class Program
    {
        static void Main(string[] args) {        
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope()){
                var app = scope.Resolve<IApplication>();
                app.run();
            }

        }
    }
}