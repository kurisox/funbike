using Library.classes.Calculation;
using Library.classes.DataInput;
using Library.classes.GUI;
using Library.classes.Offer;

namespace Library
{
    public class SimplePriceComparison : IPriceComparison
    {

        private IOfferManager offerManager;
        private IDataInputService dataInputService;
        private ICalculationService calculationService;
        private IGUIService gUIService;

        public SimplePriceComparison(IOfferManager offerManager, IDataInputService dataInputService, ICalculationService calculationService, IGUIService gUIService){
            this.offerManager = offerManager;
            this.dataInputService = dataInputService;
            this.calculationService = calculationService;
            this.gUIService = gUIService;
        }


        public void run()
        {
            throw new NotImplementedException();
        }
    }
}