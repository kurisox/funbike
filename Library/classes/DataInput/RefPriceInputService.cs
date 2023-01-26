using Library.classes.Exceptions;
using Library.classes.GUI;
using Library.classes.Offer;
using Library.classes.Offer.Offer_Schema;

namespace Library.classes.DataInput
{
    public class RefPriceInputService : IDataInputService
    {
        IGUIService iGUIService;
        public RefPriceInputService(IGUIService iGUIService){
            this.iGUIService = iGUIService;
        }
        public OfferSchema dataInput()
        {
            return OfferFactory.createOffer(addFixedValue(1), addPercentValue(2), addPercentValue(3), addFixedValue(4));
        }

        private double addFixedValue(int step){
            double fixedValue = 0;
            Boolean inputFinshed = false;
            do{
                try{
                    this.iGUIService.offerMenu(step);
                    fixedValue = Convert.ToDouble(System.Console.ReadLine());
                    if(fixedValue < 0){
                        throw new InvalidNumberException("Eingabe kleiner als 0");
                    }
                    inputFinshed = true;
                    this.iGUIService.inputAdded();
                }catch(InvalidNumberException ex){
                    this.iGUIService.inputOutOfBounce(ex.Message);
                }catch(FormatException){
                    this.iGUIService.wrongFormat();
                }
            }while(!inputFinshed);

            return fixedValue;
        }

        private double addPercentValue(int step){
            double percentValue = 0;
            Boolean inputFinished = false;
            do{
                try{
                    this.iGUIService.offerMenu(step);
                    percentValue = Convert.ToDouble(System.Console.ReadLine());
                    if(percentValue < 0){
                        throw new InvalidNumberException("Eingabe kleiner als 0");
                    }
                    inputFinished = true;
                    this.iGUIService.inputAdded();
                }catch(IndexOutOfRangeException ex){
                    this.iGUIService.inputOutOfBounce(ex.Message);
                }catch(FormatException){
                    this.iGUIService.wrongFormat();
                }
            }while(!inputFinished);
            return percentValue;
        
        }
    }
}