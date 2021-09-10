using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Instance obj = new Instance();
            obj.compute();
            obj.compute(7);
            obj.compute("Vision Hunt Decree");
            obj.compute(1,"Immovable mountains");
            obj.compute("Immovable mountains", 2);
            Console.ReadKey();
        }
    }
    class Instance
    {
        public void compute()
        {
            Console.WriteLine("No parameters");
        }
        public void compute(int number)
        {
            Console.WriteLine("Parameter type 'integer', value=> {0}", number);
        }
        public void compute(string word)
        {
            Console.WriteLine("Parameter type 'string', value=> {0}", word);
        }
        public void compute(int num, string word)
        {
            Console.WriteLine("Parameter count '2', value=> index: {0} title: {1}", num, word);
        }
        public void compute(string word, int num)
        {
            Console.WriteLine("Parameter count '2', value=> title: {0} count: {1}", num, word);
        }
    }
}
