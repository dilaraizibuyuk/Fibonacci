using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 1;
            int sayi;

            Console.WriteLine("Fibonacci dizisi kaç elemanlı olsun?");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("===========================================");
            Console.WriteLine(x+" "+y+" ");
            for (int i = 0; i <=sayi ; i++)
            {
                int z = x + y;
                Console.WriteLine(z+" ");
                x = y;
                y = z;

               
            }
            Console.ReadLine();
        }
    }
}
 