using Autofac;
using Library;
using Library.classes.Calculation;
using Library.classes.DataInput;
using Library.classes.GUI;
using Library.classes.Offer;

namespace funbike.DependencyInjectionConfigs
{
    public class SimpleContainerConfig
    {
        public static IContainer Configure(){
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<SimplePriceComparison>().As<IPriceComparison>();
            builder.RegisterType<SimpleOfferManager>().As<IOfferManager>();
            builder.RegisterType<DataInputService>().As<IDataInputService>();
            builder.RegisterType<CalculationService>().As<ICalculationService>();
            builder.RegisterType<SimpleGUIService>().As<IGUIService>();

            return builder.Build();
        }
    }
}