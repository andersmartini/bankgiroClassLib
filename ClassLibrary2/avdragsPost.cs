using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    class avdragsPost : BetalningsPost
    {
        public string TrKod = "15";
        public avdragsPost(string bgNumber, string OCR, string belopp, string paydate, string info) : BetalningsPost(string bgNumber, string OCR, string belopp, string paydate, string info );
        //AvdragsPost är urformad exakt som en BetalningsPost, med TrKod som enda skillnad, samt 
        // att belopp här avser avdragsbelopp istället för betalningsbelopp och att
        // info i avdragsposten bara visas i återredovisning till avsändaren



    }
}
