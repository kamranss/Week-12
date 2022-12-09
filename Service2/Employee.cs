using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service2
{
    internal class Employee
    {
        public static int Count = 0;
        public readonly int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birthday { get; set; }
        public int Salary { get; set; }

        public Employee[] arr;


        public Employee(DateOnly birthday)
        {
            Count++;
            Id = Count;

            Birthday = birthday;

        }

        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = employee;

        }

        public int FindEmployee(DateOnly a, DateOnly b, int salary)
        {
            int count = 0;
            foreach (var item in arr)
            {

                if (item.Birthday > a && item.Birthday < b && item.Salary > 2000 || item.Birthday < a && item.Birthday > b && item.Salary > 2000)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
