using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service2
{
    public class EmployeesDataBase
    {
        public Employee[] arr;


        public EmployeesDataBase()
        {
            arr = new Employee[0];
        }

        #region Adding new Employee
        public void AddEmployee(Employee employee)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = employee;

        }
        #endregion

        #region Find Employees number according to the given parameters
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
        #endregion

        #region Showing all Employees Info
        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].ShowEmployeeInfo();
            }
        }
        #endregion



    }
}
