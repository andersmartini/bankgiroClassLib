using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class Post
    {
        public string TrKod;
        protected string ensureCorrectLength(int Len)
        {
            return ensureCorrectLength(" ", Len, "left", ' ');
        }
        protected string ensureCorrectLength(string Val,int Len, string side, char pad)
        {
            if(Val.Length > Len){
                throw new InvalidOperationException();
            }
            else if (side == "left")
            {
                return Val.PadLeft(Len, pad);

            }
            else
            {
                return Val.PadRight(Len, pad);
            }    
        }
    }
}
