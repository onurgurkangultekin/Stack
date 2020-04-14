using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Program
    {
        static void Main()
        {
            Stack<string> banknotes = new Stack<string>();
            Console.WriteLine("size: " + banknotes.Size());
            banknotes.Push("200 TL");
            banknotes.Push("100 TL");
            banknotes.Push("50 TL");
            banknotes.Push("20 TL");
            banknotes.Push("10 TL");
            banknotes.Push("5 TL");

            Console.WriteLine("size: " + banknotes.Size());

            foreach (var item in banknotes)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine(banknotes.Peak());
            Console.WriteLine("size: " + banknotes.Size());

            Console.WriteLine(banknotes.Pop());
            Console.WriteLine(banknotes.Pop());
            Console.WriteLine("size: " + banknotes.Size());

            foreach (var item in banknotes)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
