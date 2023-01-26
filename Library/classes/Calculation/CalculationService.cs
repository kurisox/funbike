using Library.classes.Offer;

namespace Library.classes.Calculation
{
    public class CalculationService : ICalculationService
    {
        public OfferSchema calcOffer(OfferSchema offer)
        {
            offer.deliveryDiscountInEuro = calcDiscountsInEuro(offer.listPrice, offer.deliveryDiscount);
            offer.targetPurchasePrice = calcWithFixedCosts(offer.listPrice, (-1) * offer.deliveryDiscountInEuro);
            offer.deliverySkontoInEuro = calcDiscountsInEuro(offer.targetPurchasePrice, offer.deliverySkonto);
            offer.cashPurchasePrice = calcWithFixedCosts(offer.targetPurchasePrice, (-1) * offer.deliverySkontoInEuro);
            offer.referencePrice = calcWithFixedCosts(offer.cashPurchasePrice, offer.referenceCosts);
            return offer;
        }

        private double calcDiscountsInEuro(double price, double discount){
            return price * (discount / 100);
        }

        private double calcWithFixedCosts(double price, double costs){
            return price + costs;
        }
    }
}