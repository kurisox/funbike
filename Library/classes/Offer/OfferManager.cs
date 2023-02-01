namespace Library.classes.Offer
{
    public class OfferManager : IOfferManager
    {
        private Dictionary<Int32, OfferSchema> offers;
        private List<OfferSchema> bestOffers;
        private int listSize = 5;

        public OfferManager(){
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

        public List<OfferSchema> getAllOffersAsList()
        {
            throw new NotImplementedException();
        }

        public List<OfferSchema> getBestOffers()
        {
            this.bestOffers.Clear();
            foreach (KeyValuePair<Int32, OfferSchema> item in this.offers)
            {
                if(this.bestOffers.Count == 0){
                    this.bestOffers.Add(item.Value);
                }else{
                    if(this.bestOffers[0].referencePrice == item.Value.referencePrice){
                    this.bestOffers.Add(item.Value);
                    }
                }

                if(this.bestOffers[0].referencePrice > item.Value.referencePrice){
                    this.bestOffers.Clear();
                    this.bestOffers.Add(item.Value);
                }

            }
            return this.bestOffers;
        }

        public int getListSize()
        {
            return this.listSize;
        }
    }
}