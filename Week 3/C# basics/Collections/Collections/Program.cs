using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(9);
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Current capacity at {0} bytes", arrayList.Capacity);

            Hashtable hashTable = new Hashtable();
            hashTable["id"] = 1;
            hashTable["name"] = "Anandu R";

            foreach (var key in hashTable.Keys)
            {
                Console.Write(hashTable[key] + " ");
            }
            Console.WriteLine();
            


            Console.ReadKey();
        }
    }
}
