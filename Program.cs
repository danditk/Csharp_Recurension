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

        }

        private static bool Strong(int number)
        {
            throw new NotImplementedException();
        }
    }
}
