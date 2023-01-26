using Library.classes.Calculation;
using Library.classes.DataInput;
using Library.classes.GUI;
using Library.classes.Offer;

namespace Library
{
    public class PriceComparison : IPriceComparison
    {
        private IOfferManager offerManager;
        private IDataInputService dataInputService;
        private ICalculationService calculationService;
        private IGUIService gUIService;

        private Boolean endProgram;

        public PriceComparison(IOfferManager offerManager, IDataInputService dataInputService, ICalculationService calculationService, IGUIService gUIService){
            this.offerManager = offerManager;
            this.dataInputService = dataInputService;
            this.calculationService = calculationService;
            this.gUIService = gUIService;
            this.endProgram = false;
        }
        public void run()
        {
            throw new NotImplementedException();
        }
    }
}