using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    class avdragsPost : BetalningsPost
    {
        public avdragsPost(string bgNumber, string OCR, string belopp, string paydate, string info) : base(bgNumber,OCR, belopp, paydate, info )
        {    
            this.TrKod = "15";
        }
        
        
        
        //AvdragsPost är urformad exakt som en BetalningsPost, med TrKod som enda skillnad, samt 
        // att belopp här avser avdragsbelopp istället för betalningsbelopp och att
        // info i avdragsposten bara visas i återredovisning till avsändaren



    }
}
