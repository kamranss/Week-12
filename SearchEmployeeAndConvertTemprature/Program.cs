// See https://aka.ms/new-console-template for more information

using Service1;
using Service2;

#region Convert Celcius to Kelvin
Celcius celcius = new Celcius(23);

Kelvin kelvin = celcius;

Console.WriteLine(kelvin.KDegree);
#endregion

Employee employee1 = new Employee(Convert.ToDateTime(12 - 03 - 1992));
employee1.Salary = 2000;
Employee employee2 = new Employee(Convert.ToDateTime(12 - 03 - 1994));
employee2.Salary = 2300;
Employee employee3 = new Employee(Convert.ToDateTime(12 - 03 - 2002));
employee3.Salary = 1800;
Employee employee4 = new Employee(Convert.ToDateTime(12 - 03 - 2003));
employee4.Salary = 4000;
Employee employee5 = new Employee(Convert.ToDateTime(12 - 03 - 1985));
employee5.Salary = 2654;
Employee employee6 = new Employee(Convert.ToDateTime(12 - 03 - 1987));
employee6.Salary = 3567;
Employee employee7 = new Employee(Convert.ToDateTime(12 - 03 - 1997));
employee7.Salary = 1200;
Employee employee8 = new Employee(Convert.ToDateTime(12 - 03 - 2000));
employee8.Salary = 1700;


employee1.AddEmployee(employee1);
employee2.AddEmployee(employee2);
employee3.AddEmployee(employee3);
employee4.AddEmployee(employee4);
employee5.AddEmployee(employee5);
employee6.AddEmployee(employee6);
employee7.AddEmployee(employee7);
employee8.AddEmployee(employee8);




