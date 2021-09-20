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
            Solver<int> sObjInt = new Solver<int>(1,1);
            Console.WriteLine(sObjInt.computeEqual());
            Solver<string> sObjStr = new Solver<string>("a","b");
            Console.WriteLine(sObjStr.computeEqual());
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
    class Solver<T>
    {
        private T a;
        private T b;
        public Solver(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public bool computeEqual()
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
