using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class BetalningsPost :Post
    {
        public string TrKod = "14";
        //Mottagares Bankgironummer, högerställs till och fylls med nollor tills längden är 10 tecken
        private string _BGnumber;
        public string BGNumber
        {  
             set 
             {
                if(this.lengthValidator(value, 10)){
                     char pad = '0';
                    _BGnumber = value.PadLeft(10, pad);
                }
            }
            get
            {
                return _BGnumber;
            }
        } 
        
        //OCR-referens ELLER fakturanummer, fylls med blanksteg tills total längd = 25 tecken
        private string _OCR;
        public string OCR
        {
            set
            {
                if(this.lengthValidator(value, 25)){
                    _OCR = value.PadRight(25);
                }
                
}
            get
            {
                return _OCR;
}
        }
        private string _belopp;
        public string belopp{
        set
        {
            if (this.lengthValidator(value, 12))
            {
                char pad = '0';
                _belopp = value.PadLeft(12, pad);
            }
        }
        get
        {
            return _belopp;
        }

}


        private string _payDate;
        public string payDate
        {
            get
            {
                return _payDate;
            }
            set
            {
                if (value.Length == 6)
                {
                    _payDate = value;
                }else{
                    Console.WriteLine("date must be 6 digits 'yyMMdd' or 'GENAST' ");
                }
            }
        }

        private string _info;
        public string info
        {
            get {
                return _info;
            }
            set {
                if (this.lengthValidator(value, 20))
                {
                    _info = value.PadRight(20);
                }
            }
        }

        public string Post {
            get {
                var _post = TrKod + _BGnumber + _OCR + _belopp + _payDate + "     " + _info;
                if (_post.Length == 80)
                {
                    return _post;

                }
                else
                {
                    return "Some parameter was inserted incorrectly, try again";
                }
            }
        }

    }
}
