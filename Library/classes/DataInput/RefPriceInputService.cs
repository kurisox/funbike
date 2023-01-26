using Library.classes.Exceptions;
using Library.classes.Offer;
using Library.classes.Offer.Offer_Schema;

namespace Library.classes.DataInput
{
    public class RefPriceInputService : IDataInputService
    {
        public OfferSchema dataInput()
        {
            return OfferFactory.createOffer(addFixedValue(1), addPercentValue(2), addPercentValue(3), addFixedValue(4));
        }

        private double addFixedValue(int step){
            double fixedValue = 0;
            Boolean inputFinshed = false;
            do{
                try{
                    fixedValue = Convert.ToDouble(System.Console.ReadLine());
                    if(fixedValue < 0){
                        throw new InvalidNumberException("Eingabe kleiner als 0");
                    }
                    inputFinshed = true;
                }catch(InvalidNumberException ex){
                }catch(FormatException){
                }
            }while(!inputFinshed);

            return fixedValue;
        }

        private double addPercentValue(int step){
            double percentValue = 0;
            Boolean inputFinished = false;
            do{
                try{
                    percentValue = Convert.ToDouble(System.Console.ReadLine());
                    if(percentValue < 0){
                        throw new InvalidNumberException("Eingabe kleiner als 0");
                    }
                    inputFinished = true;
                }catch(IndexOutOfRangeException ex){
                    
                }catch(FormatException){
                    
                }
            }while(!inputFinished);
            return percentValue;
        
        }
    }
}