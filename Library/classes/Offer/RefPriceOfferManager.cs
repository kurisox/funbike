namespace Library.classes.Offer
{
    public class RefPriceOfferManager
    {
        private Dictionary<Int32, OfferSchema> offers;
        private List<OfferSchema> bestOffers;
        private int listSize = 5;

        public RefPriceOfferManager(){
            this.offers = new Dictionary<int, OfferSchema>();
            this.bestOffers = new List<OfferSchema>();
        }
    }
}