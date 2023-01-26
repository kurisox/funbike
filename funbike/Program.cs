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
            /*IPriceComparison priceComparison = new PriceComparison(new OfferManager(), new DataInputService(), new CalculationService(), new GUIService());
            priceComparison.run();*/
            
            var container = ConfigContainer.Configure();

            using (var scope = container.BeginLifetimeScope()){
                var app = scope.Resolve<IApplication>();
                app.run();
            }

        }
    }
}