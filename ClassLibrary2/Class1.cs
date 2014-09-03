using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class BetalningsPost : Post
    {
        public string override TrKod = "14";
        
        //Mottagares Bankgironummer, högerställs till och fylls med nollor tills längden är 10 tecken
        public StringBuilder BGNumber = new Stringbuilder(BankGiroNummer){  
             //ToDo: felmedelande ifall bankgironummer längre än 10 tecken angetts.Bör även verifiera att alla tecken är siffror.

            while(BankGiroNummer.Length<10){
               BankGiroNummer = BankGiroNummer.insert(0,"0")
            } 
        }
        //OCR-referens ELLER fakturanummer, fylls med blanksteg tills total längd = 25 tecken
        public Stringbuilder OCR = new StringBuilder(OCR){
            //ToDo: felmedelande ifall längre än 25 tecken
            while(OCR.Length<25){
                OCR = OCR.Append(" ")
            }
        }


        public string payDate (Date){
        }

    }
}
