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
            throw new NotImplementedException();
        }

        public void wrongFormat()
        {
            throw new NotImplementedException();
        }
    }
}