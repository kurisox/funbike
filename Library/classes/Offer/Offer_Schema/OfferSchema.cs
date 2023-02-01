namespace Library.classes.Offer
{
    public class OfferSchema
    {
        public int offerID  {get; set; }
        public double listPrice { get; set; }
        public double deliveryDiscount { get; set; }
        public double deliveryDiscountInEuro {get; set;}
        public double targetPurchasePrice { get; set; }
        public double deliverySkonto { get; set; }
        public double deliverySkontoInEuro {get; set;}
        public double cashPurchasePrice { get; set; }
        public double referenceCosts { get; set; }
        public double referencePrice { get; set; }

        public OfferSchema(){}
        public OfferSchema(int offerID, double listPrice, double deliveryDiscount, double deliverySkonto, double referenceCosts)
        {
            this.offerID = offerID;
            this.listPrice = listPrice;
            this.deliveryDiscount = deliveryDiscount;
            this.deliverySkonto = deliverySkonto;
            this.referenceCosts = referenceCosts;
        }
    }
}