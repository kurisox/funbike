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

        private double referencePriceLimit;
        private int customerCategory;
        private double customerDiscount;

        public SimplePriceComparison(IOfferManager offerManager, IDataInputService dataInputService, ICalculationService calculationService, IGUIService gUIService){
            this.offerManager = offerManager;
            this.dataInputService = dataInputService;
            this.calculationService = calculationService;
            this.gUIService = gUIService;
        }


        public void run()
        {
            //erstellt zwei Offer-Objekte vor der Dateneingabe
            OfferSchema newOffer1 = new OfferSchema();
            OfferSchema newOffer2 = new OfferSchema();

            //Kundenkategorie eintragen
            System.Console.WriteLine("Eingabe Kundenkategorie");
            this.customerCategory = this.dataInputService.customerCategory();

            //Dateneingabe für die beiden Offer-Objekte
            System.Console.WriteLine("Eingabe Bezugspreislimit");
            this.referencePriceLimit = this.dataInputService.listPriceLimit();

            System.Console.WriteLine("Eingabe Angebot 1\n");
            newOffer1 = this.dataInputService.dataInput();
            System.Console.WriteLine("Eingabe Angebot 2\n");
            newOffer2 = this.dataInputService.dataInput();
            
            //Berechnung der fehlenden Kostenstellen
            newOffer1 = this.calculationService.calcOffer(newOffer1);
            newOffer2 = this.calculationService.calcOffer(newOffer2);

            switch(this.customerCategory){
                case 1:
                    this.customerDiscount = 0.1;
                    break;
                case 2:
                    this.customerDiscount = 0.12;
                    break;
                case 3:
                    this.customerDiscount = 0.15;
                    break;
                case 4:
                    this.customerDiscount = 0.20;
                    break;        
                case 5:
                    this.customerDiscount = 0.30;
                    break;
                default :
                    this.customerDiscount = 0;
                    break;    
            }

            //fügt customerrabatt hinzu
            newOffer1.referencePrice = this.calculationService.calcWithCustomerDiscount(newOffer1, this.customerDiscount);
            newOffer2.referencePrice = this.calculationService.calcWithCustomerDiscount(newOffer2, this.customerDiscount);

            //Hinzufügen der Offer zum OfferManager
            this.offerManager.addOffer(newOffer1);
            this.offerManager.addOffer(newOffer2);

            //Ausgabe günstigstes Angebot
            this.gUIService.showBestOffers(this.offerManager.getBestOffers());

            //Ausgabe der Angebote
            this.gUIService.showOffers(this.offerManager.getAllOffersAsList(), this.referencePriceLimit);
        }
    }
}