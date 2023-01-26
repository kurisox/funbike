namespace Library.classes.Offer
{
    public class RefPriceOfferManager : IOfferManager
    {
        private Dictionary<Int32, OfferSchema> offers;
        private List<OfferSchema> bestOffers;
        private int listSize = 5;

        public RefPriceOfferManager(){
            this.offers = new Dictionary<int, OfferSchema>();
            this.bestOffers = new List<OfferSchema>();
        }

        public OfferSchema addOffer(OfferSchema offer)
        {
            this.offers.Add(offer.offerID, offer);
            return offer;
        }

        public Dictionary<int, OfferSchema> getAllOffers()
        {
            return this.offers;
        }

        public List<OfferSchema> getBestOffers()
        {
            throw new NotImplementedException();
        }

        public int getListSize()
        {
            throw new NotImplementedException();
        }
    }
}