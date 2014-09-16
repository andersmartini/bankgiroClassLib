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
        private string BgNumber;//Mottagares BankGiroNummer
        private string OCR;     //OCR-referens ELLER fakturanummer, fylls med blanksteg tills total längd = 25 tecken
        private string belopp;   //belopp som ska betalas
        private string payDate; //datum för utbetalning
        private string info;
        public BetalningsPost(string bgNumber, string OCR, string belopp, string paydate, string info)
        {
            this.BgNumber = ensureCorrectLength(bgNumber, 10, "left", '0');
            this.info = ensureCorrectLength(info, 20, "right", ' ');
            this.payDate = ensureCorrectLength(paydate, 6, "force", ' ');
            this.belopp = ensureCorrectLength(belopp, 12, "left", '0');
            this.OCR = ensureCorrectLength(OCR, 25, "right", ' ');
        }
        public string Post {
            get {
                var _post = TrKod + BgNumber + OCR + belopp + payDate + ensureCorrectLength(5) + info;
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
