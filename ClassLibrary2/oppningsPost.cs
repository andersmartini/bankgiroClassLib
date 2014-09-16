using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class oppningsPost : Post
    {
        public string TrKod = "11";

        //Avsändarens Bankgironummer, högerställs och fylls med nollor tills längd = 10
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
        public string sendDate = DateTime.Now.ToString(@"yyMMdd");
        public string product = "LEVERANTÖRSBETALNINGAR";
        private string _currency;
        public string currency 
        {
            get 
            {
                return _currency;
            }
            set 
            {
                if (new []{"SEK","EUR"}.Contains(value.ToUpper()))
                {
                    _currency = value.ToUpper();
                }
                else 
                {
                    throw new InvalidOperationException("invalid currency!");
                }
            }
        }

        public string post
        {
            get 
            {
                return TrKod + BGNumber + sendDate + product + ensureCorrectLength(19) + currency + ensureCorrectLength(18);
            }
        }
    }
}
