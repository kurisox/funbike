namespace Library.classes.Offer.Offer_Schema
{
    public class OfferFactory
    {
        private static readonly Random random = new Random();

        private OfferFactory(){
        }

        public static OfferSchema createOffer(double listPrice, double deliveryDiscount, double deliverySkonto, double referenceCosts){
            return new OfferSchema(random.Next(1,10000), listPrice, deliveryDiscount, deliverySkonto, referenceCosts);
        }
    }
}