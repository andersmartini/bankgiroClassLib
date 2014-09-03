using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class BetalningsPost
    {
        public string TrKod = "14";
        //Mottagares Bankgironummer, högerställs till och fylls med nollor tills längden är 10 tecken
        public string BGNumber
        {  
             set 
             {
             BGNumber = value;
             }
            get
            {
                char pad = '0';
                return BGNumber.PadLeft(10,pad);
            }
        } 
        
        //OCR-referens ELLER fakturanummer, fylls med blanksteg tills total längd = 25 tecken
        public string OCR
        {
            set
            {
                OCR = value;
}
            get
            {
                return OCR.PadLeft(25);
}
        }

        public string belopp{
        set
        {
            char pad = '0';
            belopp = value.PadLeft(12,pad);
        }
        get
        {
            return belopp;
        }

}    



        public string payDate
        {
            get
            {
                return payDate;
            }
            set
            {
                if (value.Length == 6)
                {
                    payDate = value;
                }else{
                    Console.WriteLine("date must be 6digits yyMMdd or 'GENAST' ");
                }
            }
        }

    }
}
