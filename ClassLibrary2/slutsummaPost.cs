using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
   public class slutsummaPost : Post
    {
        public string TrKod = "29";

        //Avsändarens bankgironummer
        private string BgNumber;
        //Antalet Betalinginsposter (Tk 14 - 17) i detta avsnitt
        private string numPost;
        private string negativeTotal;
        private string totalBelopp;

       public slutsummaPost(string bgNummer,string numpost,string totalbelopp)
       {
           this.BgNumber = ensureCorrectLength(bgNummer, 10, "left", '0');
           this.numPost = ensureCorrectLength(numPost, 8, "left", '0');
           this.totalBelopp = ensureCorrectLength(totalBelopp, 12, "left", '0');
       }


        public string Post
        {
            get
            {
                var _post = TrKod + BgNumber + numPost + totalBelopp + negativeTotal;
                return ensureCorrectLength(_post, 80, "force", ' ');
            }


        }



    }
}
