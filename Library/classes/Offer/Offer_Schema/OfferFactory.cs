namespace Library.classes.Offer.Offer_Schema
{
    public class OfferFactory
    {
        private static Random random;

        private OfferFactory(){
            random = new Random();
        }

        public static OfferSchema createOffer(double listPrice, double deliveryDiscount, double deliverySkonto, double referenceCosts){
            return new OfferSchema(random.Next(1,10000), listPrice, deliveryDiscount, deliverySkonto, referenceCosts);
        }
    }
}