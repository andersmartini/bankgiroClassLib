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
            Console.WriteLine("welcome to the test-CLI for the BG-library");
            
            Console.WriteLine("start by filling in the BG-number of the Payer:");
            var B = Console.ReadLine();
            var av = new avsnitt(B, "SEK");
            Console.WriteLine("We´ll be using SEK for currency to keep things simple { new avsnitt(<BG>,'SEK') }  ");
            Console.WriteLine("Now lets add a recipients BG-number:");
            var Bg = Console.ReadLine();
            Console.WriteLine("and now an amount to transfer to that acount:");
            var s = Console.ReadLine();
            Console.WriteLine("OCR-reference:");
            var o = Console.ReadLine();
            Console.WriteLine("Now type the date to execute the payment in YYMMDD format, or the word 'GENAST'");
            var d = Console.ReadLine();
            Console.WriteLine("And finally an info-text, a message of your choice");
            var m = Console.ReadLine();
            av.addPayment(Bg, o, s, d, m);
            Console.WriteLine("we now have a paymentgroup object populated with a single payment and will save that to a file");
            var F = new BankgiroFil();
            F.addPayGroup(av);
            F.savefile();
            Console.WriteLine("unless something went wrong, there should now be a new file created in C:\\");
            Console.ReadKey();

        }
    }
}
