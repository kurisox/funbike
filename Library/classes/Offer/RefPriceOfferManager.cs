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
            throw new NotImplementedException();
        }

        public Dictionary<int, OfferSchema> getAllOffers()
        {
            throw new NotImplementedException();
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