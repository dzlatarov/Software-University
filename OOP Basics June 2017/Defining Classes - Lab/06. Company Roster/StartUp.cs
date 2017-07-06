using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StartUp
{
    public static void Main(string[] args)
    {
        var numberOfEmployees = int.Parse(Console.ReadLine());

        Employees employees = new Employees();

        for (int i = 0; i < numberOfEmployees; i++)
        {
            var employeeInfo = Console.ReadLine().Split(' ');

            if (employeeInfo.Length == 4)
            {
                var employee = new Employee(
                    employeeInfo[0],
                    double.Parse(employeeInfo[1]),
                    employeeInfo[2],
                    employeeInfo[3]);

                employees.AddEmployee(employee);
            }

            if (employeeInfo.Length == 5)
            {
                if (int.TryParse(employeeInfo[4], out int age))
                {
                    var employee = new Employee(
                        employeeInfo[0],
                        double.Parse(employeeInfo[1]),
                        employeeInfo[2],
                        employeeInfo[3],
                        int.Parse(employeeInfo[4]));

                    employees.AddEmployee(employee);
                }
                else
                {
                    var employee = new Employee(
                        employeeInfo[0],
                        double.Parse(employeeInfo[1]),
                        employeeInfo[2],
                        employeeInfo[3],
                        employeeInfo[4]);

                    employees.AddEmployee(employee);
                }
            }

            if (employeeInfo.Length == 6)
            {
                var employee = new Employee(
                    employeeInfo[0],
                    double.Parse(employeeInfo[1]),
                    employeeInfo[2],
                    employeeInfo[3],
                    employeeInfo[4],
                    int.Parse(employeeInfo[5]));

                employees.AddEmployee(employee);
            }
        }

        employees.HighestAverageSalaryDepartment();
    }
}

