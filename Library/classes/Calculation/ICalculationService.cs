using Library.classes.Offer;

namespace Library.classes.Calculation
{
    public interface ICalculation
    {
         OfferSchema calcOffer(OfferSchema offer);
    }
}