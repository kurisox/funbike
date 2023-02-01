using Library.classes.Offer;

namespace Library.classes.GUI
{
    public interface IGUIService
    {
        void printMainMenu();

        int choiceMainMenu();

        int offerMenu(int inputStep);

        void wrongFormat();

        void inputOutOfBounce();

        void inputOutOfBounce(string message);

        void inputAdded();

        void offerAdded(Boolean added);

        void showOffers(Dictionary<Int32, OfferSchema> offers);

        void showOffers(List<OfferSchema> offer);

        void showBestOffers(List<OfferSchema> offers);
    }
}