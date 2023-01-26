using Library.classes.Offer;

namespace Library.classes.Calculation
{
    public interface ICalculationService
    {
         OfferSchema calcOffer(OfferSchema offer);
    }
}