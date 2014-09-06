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
        private string _BGnumber;
        public string BgNumber
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

        //Antalet Betalinginsposter (Tk 14 - 17) i detta avsnitt
        private string _numPost;
        public string numPost
        {
            set
            {
                _numPost = this.ensureCorrectLength(value, 8, "left", '0');
            }
            get
            {
                return _numPost;
            }
        }

        public string negativeTotal;
        private string _totalBelopp;
        public string totalBelopp
        {
            set
           {
               _totalBelopp = ensureCorrectLength(value, 12, "left", '0');
               if (int.Parse(_totalBelopp) < 0)
               {
                   negativeTotal = "-";
               }else
               {
                    negativeTotal = " ";
               }
           }
            get 
            {
                return _totalBelopp;
            }
        }



        public string Post
        {
            get
            {
                var _post = TrKod + BgNumber + numPost + totalBelopp + negativeTotal;
                return ensureCorrectLength(_post, 80, "right", ' ');
            }


        }



    }
}
