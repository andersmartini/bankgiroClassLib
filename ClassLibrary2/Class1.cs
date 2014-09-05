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
                 _BGnumber = this.ensureCorrectLength(value, 10, "left", '0');
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
                _OCR = this.ensureCorrectLength(value, 25, "right", ' ');
                
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
            _belopp = this.ensureCorrectLength(value, 12, "left",'0');
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
                _info = this.ensureCorrectLength(value, 20, "right", ' ');
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
