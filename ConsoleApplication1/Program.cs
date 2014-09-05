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
            List<string> posts = new List<string>();


            var oppning = new oppningsPost();
            Console.WriteLine("Börja med att fylla i det bankgironummer som betalningar skall göras FRÅN");
            oppning.BGNumber = Console.ReadLine();
            Console.WriteLine("tackar! vänligen ange även i vilken valuta du önskar betala (SEK eller EUR)");
            oppning.currency = Console.ReadLine();
            posts.Add(oppning.post);
            


            Console.WriteLine("Skapa en ny betalning,ange belopp:");
            var betalning = new BetalningsPost();
            betalning.belopp = Console.ReadLine();
            Console.WriteLine("ditt bellop skrevs som: " + betalning.belopp + " ange bankgiro som betalningen ska göras TILL: ");
            betalning.BGNumber = Console.ReadLine();
            Console.WriteLine("överföring registrerad till mottagare " + betalning.BGNumber + " ange OCR refferens:");
            betalning.OCR = Console.ReadLine();
            Console.WriteLine("OCR skriven som " + betalning.OCR + " ange betalningsdatum:");
            betalning.payDate = Console.ReadLine();
            Console.WriteLine("datum skrevs som " + betalning.payDate + " ange info:");
            betalning.info = Console.ReadLine();
            Console.WriteLine("Din slutgiltiga Post är: ");
            Console.WriteLine(betalning.Post);
            Console.WriteLine("och postens totala längd är: " + betalning.Post.Length);
            Console.ReadLine();
            posts.Add(betalning.Post);

            Console.WriteLine("din fil med samtliga poster är:");
            foreach (string post in posts)
            {
                Console.WriteLine(post);
            }
            Console.ReadLine();
        }
    }
}
