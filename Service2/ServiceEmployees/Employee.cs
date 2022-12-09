using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service2
{
    public class Employee
    {
        public static int Count = 0;
        public readonly int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        ////public Employee[] arr;


        public Employee(DateTime birthday)
        {
            Count++;
            Id = Count;

            Birthday = birthday;

        }

        public void ShowEmployeeInfo()
        {
            Console.WriteLine($"Id: {Id} | Name: {Name} | Surname: {Surname} | Birthday: {Birthday.ToShortDateString()} | Salary: {Salary}");
        }



    }
}
