using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    abstract class Post
    {
        public virtual string TrKod
        
        public bool verifyTK(){ //verify that TrKod is a 2digits long
            if(this.TrKod.Length===2){
                return true
            }else{
                return false
            }
        }

    }
}
