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
        
        protected bool lengthValidator(string Val,int Len)
        {
            if(Val.Length > Len){
                throw new InvalidOperationException();
            }else{
                return true;
            }    
        }
    }
}
