using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankgiro
{
    public class BankgiroFil
    {
        private string file;
        private string kommunikationsSätt = "IBGLK";
        private string kundNummer = "";

        //Lägg till en grupp betalningar i filen. dessa skapas med avsnitt constructorn. Se avsnitt.cs 
        public void addPayGroup(avsnitt avsnt)
        {
            string strng = avsnt.format();
            file += strng + Environment.NewLine;
        }

        public void savefile()
        {
            
            var fileName = "BFEP." + kommunikationsSätt + ".KO" + kundNummer +".txt";
            var dir = @"C:\Users\Karl\Downloads\" + fileName;

            System.IO.File.WriteAllText(dir, file);


        }


    }
}
