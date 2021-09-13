using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareHeights
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p_1 = new Person();
            Person p_2 = new Person();
            if(p_1 > p_2)
            {
                Console.WriteLine("Person p_1 is taller than p_2");
            }
            else
            {
                Console.WriteLine("Person p_1 is shorter than p_2");
            }
            Console.ReadKey();

            
        }
    }
    class Person
    {
        private int feet = 0;
        private int inches = 0;
        private float height = 0.0f;
        public Person()
        {
            Console.WriteLine("Initializing person ");
            Console.Write("Enter feet: ");
            this.feet = int.Parse(Console.ReadLine());
            Console.Write("Enter inches: ");
            this.inches = int.Parse(Console.ReadLine());
            this.getHeight();
        }

        private void getHeight() {
            this.height = this.feet * 30.48f + this.inches * 2.54f;
        }

        public static Boolean operator >(Person p_1, Person p_2)
        {
            if (p_1.height > p_2.height)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Boolean operator <(Person p_1, Person p_2)
        {
            if (p_1.height < p_2.height)
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
