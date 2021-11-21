using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Recurension
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NUMBER = 3;
            Stopwatch time = new Stopwatch();
            time.Start();
            Console.WriteLine(Strong(NUMBER));
            time.Stop();
            Console.WriteLine(time.ElapsedTicks);

            time.Reset();
            Console.WriteLine();

            time.Start();
            Console.WriteLine(StrongRec(NUMBER));
            time.Stop();
            Console.WriteLine(time.ElapsedTicks);

            Console.ReadKey();

        }

        private static long StrongRec(int x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                return StrongRec(x - 1) * x;
            }
        }

        private static long Strong(int x)
        {
            long result = 1;

            while (x > 1)
            {
                result *= x;
                x--;
            }

            return result;
        }
    }
}
