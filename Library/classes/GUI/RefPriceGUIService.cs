using Library.classes.Offer;

namespace Library.classes.GUI
{
    public class RefPriceGUIService : IGUIService
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
            System.Console.WriteLine("[1] Angebot hinzufügen \n" +
            "[2] Angebote anzeigen\n" +
            "[3] Beste Angebote anzeigen\n" +
            "[4] Programm beenden\n");
        }

        public void showBestOffers(List<OfferSchema> offers)
        {
            throw new NotImplementedException();
        }

        public void showOffers(Dictionary<int, OfferSchema> offers)
        {
            if(offers.Count == 0){
               System.Console.WriteLine("Keine Angebote vorhanden\n"); 
            }else{
                foreach (KeyValuePair<Int32, OfferSchema> item in offers)
                {
                    System.Console.WriteLine("  Angebot ID: " + item.Value.offerID);
                    System.Console.WriteLine("  Listeneinkaufspreis: " + item.Value.listPrice + "€");
                    System.Console.WriteLine("- Lieferrabatt: " + item.Value.deliveryDiscountInEuro + "% " + item.Value.deliveryDiscountInEuro + "€");
                    System.Console.WriteLine("= Zieleinkaufspreis: " + item.Value.targetPurchasePrice + "€");
                    System.Console.WriteLine("- Lieferskonto: " + item.Value.deliverySkonto + "% " + item.Value.deliverySkontoInEuro + "€");
                    System.Console.WriteLine("= Bareinkaufspreis: " + item.Value.cashPurchasePrice + "€");
                    System.Console.WriteLine("+ Bezugskosten: " + item.Value.referenceCosts + "€");
                    System.Console.WriteLine("= Bezugspreis: " + item.Value.referencePrice + "€\n");
                }
            }
        }

        public void wrongFormat()
        {
            throw new NotImplementedException();
        }
    }
}