namespace Library.classes.Offer
{
    public interface IOfferManager
    {
        OfferSchema addOffer(OfferSchema offer);
        int getListSize();
        List<OfferSchema> getBestOffers();
        Dictionary<Int32, OfferSchema> getAllOffers();
    }
}