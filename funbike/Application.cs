using Library;
namespace funbike
{
    public class Application : IApplication
    {
        IPriceComparison priceComparison;
        public Application(IPriceComparison priceComparison)
        {
            this.priceComparison = priceComparison;
        }

        public void run(){
            this.priceComparison.run();
        }
    }
}