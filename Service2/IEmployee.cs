using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service2
{
    public class IEmployee
    {
        public Employee[] arr;
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = employee;

        }
    }
}
