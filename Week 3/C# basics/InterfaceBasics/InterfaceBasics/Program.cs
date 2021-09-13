using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseInterface_1 t1 = new Test();
            t1.Print();
            BaseInterface_2 t2 = new Test();
            t2.Print();
            Console.ReadKey();
        }
    }
    interface BaseInterface_1
    {
        void Print();
        void Display();
    }
    interface BaseInterface_2
    {
        void Print();
    }

    class Test: BaseInterface_1, BaseInterface_2
    {
        void BaseInterface_1.Print()
        {
            Console.WriteLine("Interface 1");
        }
        void BaseInterface_1.Display()
        {
            throw new NotImplementedException();   
        }
        void BaseInterface_2.Print()
        {
            Console.WriteLine("Interface 2");
        }
    }
}
