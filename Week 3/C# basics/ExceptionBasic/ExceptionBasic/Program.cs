using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionBasic
{

    class UserAlreadyLoggedInException : Exception
    {
        public UserAlreadyLoggedInException() : base() { }
        public UserAlreadyLoggedInException(string msg) : base() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = null;
            Auth auth = new Auth();


            try
            {
                auth.login();
                Console.WriteLine("Enter an integer number: ");
                int a = int.Parse(Console.ReadLine());

                stream = new StreamReader(@"../../data/data.txt");
                Console.WriteLine(stream.ReadToEnd());

               
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
            }
            finally
            {
                if(stream != null)
                {
                    Console.WriteLine("Closing stream...");
                    stream.Close();
                }
                Console.WriteLine("Execution complete.");
            }

            Console.ReadKey();
           
        }
    }

    class Auth
    {
        private string username;
        private string password;
        private bool isLoggedIn;
        public Auth() {
            StreamReader stream = null;
            try
            {
                stream = new StreamReader(@"../../data/auth.txt");
                if(stream.ReadLine() == "user")
                {
                    this.isLoggedIn = true;
                }
                else
                {
                    this.isLoggedIn = false;
                }
            }
            catch(Exception e){
                Console.WriteLine("Unable to initiate auth service");
            }
            finally
            {
                stream.Close();
            }
            
        }

        public bool login()
        {
            if (isLoggedIn)
            {
                throw new UserAlreadyLoggedInException("User already logged in");
            }
            Console.WriteLine("Enter login credentials");
            Console.Write("Username: ");
            this.username = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Password: ");
            this.password = Console.ReadLine();
            Console.WriteLine();
            return this.saveAuth();
            
        }
        private bool saveAuth()
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(@"../../data/auth.txt");
                streamWriter.WriteLine(this.username);
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Exception occured: {0}", e);
            }
            finally
            {
                streamWriter.Close();
            }
            if (streamWriter != null)
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
