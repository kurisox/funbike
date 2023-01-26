using Library.classes.Exceptions;
using Library.classes.Offer;

namespace Library.classes.DataInput
{
    public class RefPriceInputService : IDataInputService
    {
        public OfferSchema dataInput()
        {
            throw new NotImplementedException();
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
    }
}