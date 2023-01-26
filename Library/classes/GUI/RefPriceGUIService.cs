using Library.classes.Exceptions;
using Library.classes.Offer;

namespace Library.classes.GUI
{
    public class RefPriceGUIService : IGUIService
    {
        public int choiceMainMenu()
        {
            try{
                return inputChoice();
            }catch(System.FormatException){
                System.Console.WriteLine("Ungültige Eingabe\n");
                return -1;
            }catch(InvalidNumberException ex){
                System.Console.WriteLine(ex.Message);
                return -1;
            }
        }

        private int inputChoice(){
            int menuChoice = Convert.ToInt32(System.Console.ReadLine());
            if(menuChoice > 4 || menuChoice < 1){
                throw new IndexOutOfRangeException("Auswahlmöglichkeit nicht vorhanden\n");
            }
            return menuChoice;
        }

        public void inputAdded()
        {
            System.Console.WriteLine("Eingabe erfolgreich\n");
        }

        public void inputOutOfBounce()
        {
            throw new NotImplementedException();
        }

        public void inputOutOfBounce(string message)
        {
            System.Console.WriteLine(message + "\n");
        }

        public void offerAdded(bool added)
        {
            if(added){
                System.Console.WriteLine("Angebot erfolgreich hinzugefügt\n");
            }else{
                System.Console.WriteLine("Angebot wurde nicht hinzugefügt\n");
            }
        }

        public int offerMenu(int inputStep)
        {
            int returnValue = 0;
            switch(inputStep){
                case 1:
                    System.Console.WriteLine("Eingabe Listeneinkaufspreis");
                    returnValue = 1;
                    break;
                case 2:
                    System.Console.WriteLine("Eingabe Lieferrabatt");    
                    returnValue =2;
                    break;
                case 3:
                    returnValue = 3;
                    System.Console.WriteLine("Eingabe Lieferskonto");    
                    break;
                case 4:
                    returnValue = 4;
                    System.Console.WriteLine("Eingabe Bezugskosten");    
                    break;
            }
            return returnValue;
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
            if(offers.Count == 0){
               System.Console.WriteLine("Keine Angebote vorhanden\n"); 
            }else{
                foreach (OfferSchema item in offers)
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
                    System.Console.WriteLine("- Lieferrabatt: " + item.Value.deliveryDiscount + "% " + item.Value.deliveryDiscountInEuro + "€");
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
            System.Console.WriteLine("Ungültige Eingabe\n");
        }
    }
}