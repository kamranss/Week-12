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

        private Employee[] arr;


        public Employee(DateTime birthday)
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

        public int FindEmployee(DateTime a, DateTime b, int salary)
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
