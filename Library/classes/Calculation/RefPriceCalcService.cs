using Library.classes.Offer;

namespace Library.classes.Calculation
{
    public class RefPriceCalc : ICalculation
    {
        public OfferSchema calcOffer(OfferSchema offer)
        {
            throw new NotImplementedException();
        }

        private double calcDiscountsInEuro(double price, double discount){
            return price * (discount / 100);
        }

        private double calcWithFixedCosts(double price, double costs){
            return price + costs;
        }
    }
}