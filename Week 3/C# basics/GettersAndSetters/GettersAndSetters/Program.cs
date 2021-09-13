using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Anandu R";

            Console.WriteLine("Student: Id={0}, Name={1}, PassMark={2}", student.Id, student.Name, student.PassMark);
            Console.ReadKey();
        }
    }

    class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 40;

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be negative");
                }
                this._id = value;
            }
        }

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be blank");
                }
                this._name = value;
            }
            get
            {
                return _name;
            }
        }

        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
    }

}
