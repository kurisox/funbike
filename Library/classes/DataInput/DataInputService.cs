using Library.classes.Exceptions;
using Library.classes.GUI;
using Library.classes.Offer;
using Library.classes.Offer.Offer_Schema;

namespace Library.classes.DataInput
{
    public class DataInputService : IDataInputService
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
                    if(step == 1){
                        System.Console.WriteLine("Eingabe Listeneinkaufspreis");
                    }else{
                        System.Console.WriteLine("Eingabe Bezugskosten"); 
                    }
                    fixedValue = Convert.ToDouble(System.Console.ReadLine());
                    if(fixedValue < 0){
                        throw new InvalidNumberException("Eingabe kleiner als 0");
                    }
                    inputFinshed = true;
                    System.Console.WriteLine("Eingabe erfolgreich\n");
                }catch(InvalidNumberException ex){
                    System.Console.WriteLine(ex.Message + "\n");
                }catch(FormatException){
                    System.Console.WriteLine("Ungültige Eingabe\n");
                }
            }while(!inputFinshed);

            return fixedValue;
        }

        private double addPercentValue(int step){
            double percentValue = 0;
            Boolean inputFinished = false;
            do{
                try{
                    if(step == 2){
                        System.Console.WriteLine("Eingabe Lieferrabatt");   
                    }else{
                        System.Console.WriteLine("Eingabe Lieferskonto");
                    }
                    percentValue = Convert.ToDouble(System.Console.ReadLine());
                    if(percentValue < 0){
                        throw new InvalidNumberException("Eingabe kleiner als 0");
                    }
                    inputFinished = true;
                    System.Console.WriteLine("Eingabe erfolgreich\n");
                }catch(IndexOutOfRangeException ex){
                    System.Console.WriteLine(ex.Message + "\n");
                }catch(FormatException){
                    System.Console.WriteLine("Ungültige Eingabe\n");
                }
            }while(!inputFinished);
            return percentValue;
        
        }
    }
}