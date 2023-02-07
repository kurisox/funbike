using Library.classes.Offer;

namespace Library.classes.Calculation
{
    public interface ICalculationService
    {
         OfferSchema calcOffer(OfferSchema offer);

        double calcWithCustomerDiscount(OfferSchema offer, double discount);
    }
}