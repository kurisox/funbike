using Library;
using Library.classes.DataInput;
using Library.classes.Offer;
using Library.classes.Calculation;
using Library.classes.GUI;

namespace funbike
{
    public class Program
    {
        static void Main(string[] args) {
            IPriceComparison priceComparison = new PriceComparison(new RefPriceOfferManager(), new RefPriceInputService(new RefPriceGUIService()), new RefPriceCalcService(), new RefPriceGUIService());
            priceComparison.run();

        }
    }
}