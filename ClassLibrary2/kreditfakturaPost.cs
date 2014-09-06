using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    class kreditfakturaPost : BetalningsPost
    {
        private string TrKod;
        public string bevakning
        {
            get
            {
                return TrKod;
            }
            set
            {
                if (value.ToUpper().Equals("HELA")) 
                {        // TrKoden 17 indikerar att kreditfakturan ska bevaka hela belopp se BG4900 sidan 12 
                    TrKod = "17";
                }else
                {
                    TrKod = "16";
                }
            }
        }

    }
}
