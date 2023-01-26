using Library;
using Autofac;
using System.Reflection;
using Library.classes.Calculation;
using Library.classes.Offer;
using Library.classes.GUI;
using Library.classes.DataInput;

namespace funbike
{
    public class ConfigContainer
    {
        public static IContainer Configure(){
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<PriceComparison>().As<IPriceComparison>();
            builder.RegisterType<OfferManager>().As<IOfferManager>();
            builder.RegisterType<DataInputService>().As<IDataInputService>();
            builder.RegisterType<CalculationService>().As<ICalculationService>();
            builder.RegisterType<GUIService>().As<IGUIService>();

            return builder.Build();
        }
    }
}