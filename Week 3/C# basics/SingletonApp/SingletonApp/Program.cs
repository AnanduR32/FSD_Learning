using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonObj = Singleton.instantiateSingletonApp();
            Singleton singletonObj_copy = Singleton.instantiateSingletonApp();


            Console.ReadKey();
        }
    }

    sealed public class Singleton
    {
        private static Singleton Instance = null;
        public static Singleton instantiateSingletonApp()
        {
            if(Instance == null)
            {
                Instance = new Singleton();
            }
            return Instance;
        }
        private Singleton()
        {
            Console.WriteLine("Initialized singleton application");
        }
    }
}
