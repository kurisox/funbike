namespace Library.classes.Offer
{
    public class SimpleOfferManager : IOfferManager
    {

        private List<OfferSchema> offers;
        private List<OfferSchema> bestOffers;

        public SimpleOfferManager()
        {
            this.offers = new List<OfferSchema>();
            this.bestOffers = new List<OfferSchema>();
        }

        public OfferSchema addOffer(OfferSchema offer)
        {
            this.offers.Add(offer);
            return offer;
        }

        public Dictionary<int, OfferSchema> getAllOffers()
        {
            throw new NotImplementedException();
        }

        public List<OfferSchema> getAllOffersAsList()
        {
            return this.offers;
        }

        public List<OfferSchema> getBestOffers()
        {
            return this.bestOffers;
        }

        public int getListSize()
        {
            throw new NotImplementedException();
        }
    }
}