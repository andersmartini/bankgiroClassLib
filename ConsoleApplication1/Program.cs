using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankgiro;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tja! Skapa en ny betalning,ange belopp:");
            var betalning = new BetalningsPost();
            betalning.belopp = Console.ReadLine();
            Console.WriteLine("ditt bellop skrevs som: " + betalning.belopp + "ange bankgiro: ");
            betalning.BGNumber = Console.ReadLine();
            Console.WriteLine("överföring registrerad till mottagare" + betalning.BGNumber + "ange OCR refferens:");
            betalning.OCR = Console.ReadLine();
            Console.WriteLine("OCR skriven som" + betalning.OCR + "ange betalningsdatum:");
            betalning.payDate = Console.ReadLine();
            Console.WriteLine("datum skrevs som" + betalning.payDate + "ange info:");
            betalning.info = Console.ReadLine();
            Console.WriteLine("Din slutgiltiga Post är:");
            Console.WriteLine(betalning.Post);
            Console.WriteLine("och postens totala längd är: " + betalning.Post.Length);
            Console.ReadLine();
        }
    }
}
