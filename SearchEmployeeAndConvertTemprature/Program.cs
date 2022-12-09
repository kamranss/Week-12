// See https://aka.ms/new-console-template for more information

using Service1;
using Service2;

#region Convert Celcius to Kelvin
Celcius celcius = new Celcius(23);

Kelvin kelvin = celcius;

Console.WriteLine($"Kelvin: {kelvin.KDegree}");
#endregion

#region Creating Employee info adding into Arr List and Finding the number of Employees within the given Range"
Employee employee1 = new Employee(new DateTime(1992,03,12));
employee1.Name = "Kamil";
employee1.Surname = "Seidov";
employee1.Salary = 2000;
Employee employee2 = new Employee(new DateTime(1994,03,12));
employee2.Name = "Zakir";
employee2.Surname = "Aliyev";
employee2.Salary = 2300;
Employee employee3 = new Employee(new DateTime(2002,03,12));
employee3.Name = "Samir";
employee3.Surname = "Aliyev";
employee3.Salary = 1800;
Employee employee4 = new Employee(new DateTime(2003,03,12));
employee4.Name = "Valeh";
employee4.Surname = "Ayazov";
employee4.Salary = 4000;
Employee employee5 = new Employee(new DateTime(1985,03,12));
employee5.Name = "Akira";
employee5.Surname = "Abiyev";
employee5.Salary = 2654;
Employee employee6 = new Employee(new DateTime(1985,03,12));
employee6.Name = "Eugen";
employee6.Surname = "Agayev";
employee6.Salary = 3567;
Employee employee7 = new Employee(new DateTime(1997,03,12));
employee7.Name = "Islam";
employee7.Surname = "Abayev";
employee7.Salary = 1200;
Employee employee8 = new Employee(new DateTime(2000,03,12));
employee8.Name = "Sirac";
employee8.Surname = "Amayev";
employee8.Salary = 1700;


EmployeesDataBase database = new EmployeesDataBase();

database.AddEmployee(employee1);
database.AddEmployee(employee2);
database.AddEmployee(employee3);
database.AddEmployee(employee4);
database.AddEmployee(employee5);
database.AddEmployee(employee6);
database.AddEmployee(employee7);
database.AddEmployee(employee8);

Console.WriteLine($" The number of employees within the given range is: ->> {database.FindEmployee(new DateTime(1986, 03, 12), new DateTime(2000, 03, 12), 2000)}");
#endregion 

#region Showing all Employees info 
database.ShowEmployeeInfo();
#endregion



