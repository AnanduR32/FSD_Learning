using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadandOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            parent.showMsg();
            child.showMsg();
            child.Test();
            child.Test(1);
            Console.ReadKey();
        }
    }
    class Parent
    {
        public virtual void showMsg()
        {
            Console.WriteLine("Showing message from parent");
        }
        public void Test()
        {
            Console.WriteLine("Test method parent");
        }
    }
    class Child : Parent
    {
        public override void showMsg()
        {
            Console.WriteLine("Showing message from child");
        }
        public void Test(int num)
        {
            Console.WriteLine("Test method child, number: {0}", num);
        }
    }
}
