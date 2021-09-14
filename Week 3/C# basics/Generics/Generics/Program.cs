using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual<int>(1, 2));
            Console.ReadKey();
        }

        public static bool AreEqual<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
