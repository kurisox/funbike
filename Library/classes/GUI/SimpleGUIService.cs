using Library.classes.Offer;

namespace Library.classes.GUI
{
    public class SimpleGUIService : IGUIService
    {
        public int choiceMainMenu()
        {
            throw new NotImplementedException();
        }

        public void inputAdded()
        {
            throw new NotImplementedException();
        }

        public void inputOutOfBounce()
        {
            throw new NotImplementedException();
        }

        public void inputOutOfBounce(string message)
        {
            throw new NotImplementedException();
        }

        public void offerAdded(bool added)
        {
            throw new NotImplementedException();
        }

        public int offerMenu(int inputStep)
        {
            throw new NotImplementedException();
        }

        public void printMainMenu()
        {
            throw new NotImplementedException();
        }

        public void showBestOffers(List<OfferSchema> offers)
        {
            if(offers.Count == 0){
                System.Console.WriteLine("Beide Angebot haben den selben Bezugspreis");
            }else{
                System.Console.WriteLine("Günstigstes Angebot");
                System.Console.WriteLine("Offer ID:" + offers[0].offerID);
                System.Console.WriteLine("Bezugspreis:" + offers[0].referencePrice + "€\n");
            }
        }

        public void showOffers(Dictionary<int, OfferSchema> offers)
        {
            foreach (KeyValuePair<Int32, OfferSchema> item in offers)
                {
                    System.Console.WriteLine("  Angebot ID: " + item.Value.offerID);
                    System.Console.WriteLine("  Listeneinkaufspreis: " + item.Value.listPrice + "€");
                    System.Console.WriteLine("- Lieferrabatt: " + item.Value.deliveryDiscount + "% " + item.Value.deliveryDiscountInEuro + "€");
                    System.Console.WriteLine("= Zieleinkaufspreis: " + item.Value.targetPurchasePrice + "€");
                    System.Console.WriteLine("- Lieferskonto: " + item.Value.deliverySkonto + "% " + item.Value.deliverySkontoInEuro + "€");
                    System.Console.WriteLine("= Bareinkaufspreis: " + item.Value.cashPurchasePrice + "€");
                    System.Console.WriteLine("+ Bezugskosten: " + item.Value.referenceCosts + "€");
                    System.Console.WriteLine("= Bezugspreis: " + item.Value.referencePrice + "€\n");
                }
        }

        public void showOffers(List<OfferSchema> offer)
        {
            foreach (OfferSchema item in offer)
            {
                System.Console.WriteLine("  Angebot ID: " + item.offerID);
                    System.Console.WriteLine("  Listeneinkaufspreis: " + item.listPrice + "€");
                    System.Console.WriteLine("- Lieferrabatt: " + item.deliveryDiscount + "% " + item.deliveryDiscountInEuro + "€");
                    System.Console.WriteLine("= Zieleinkaufspreis: " + item.targetPurchasePrice + "€");
                    System.Console.WriteLine("- Lieferskonto: " + item.deliverySkonto + "% " + item.deliverySkontoInEuro + "€");
                    System.Console.WriteLine("= Bareinkaufspreis: " + item.cashPurchasePrice + "€");
                    System.Console.WriteLine("+ Bezugskosten: " + item.referenceCosts + "€");
                    System.Console.WriteLine("= Bezugspreis: " + item.referencePrice + "€\n");
            }
        }

        public void wrongFormat()
        {
            throw new NotImplementedException();
        }
    }
}