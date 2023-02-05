using Library.classes.Offer;

namespace Library.classes.DataInput
{
    public interface IDataInputService
    {
        OfferSchema dataInput();

        double listPriceLimit();
    }
}