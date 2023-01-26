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
            do{
                this.gUIService.printMainMenu();
                switch(this.gUIService.choiceMainMenu()){
                    case 1:
                        Boolean added = false;
                        if(this.offerManager.getAllOffers().Count < offerManager.getListSize()){
                            OfferSchema newOffer = this.dataInputService.dataInput();
                            newOffer = this.calculationService.calcOffer(newOffer);
                            this.offerManager.addOffer(newOffer);
                            added = true;
                        }
                        
                        this.gUIService.offerAdded(added);
                        break;
                    case 2:
                        this.gUIService.showOffers(this.offerManager.getAllOffers());    
                        break;
                    case 3:
                        this.gUIService.showBestOffers(this.offerManager.getBestOffers());
                        break;    
                    case 4:
                        this.endProgram = true;
                        break;
                }
            }while(this.endProgram != true);
        }
    }
}