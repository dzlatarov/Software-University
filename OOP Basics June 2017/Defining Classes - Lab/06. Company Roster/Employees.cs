using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Employees
{
    private List<Employee> employees;

    public Employees()
    {
        this.employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        this.employees.Add(employee);
    }

    public void HighestAverageSalaryDepartment()
    {
        var depart = this.employees
             .GroupBy(em => em.Department)
             .Select(gr => new
             {
                 Name = gr.Key,
                 AverageSalary = gr.Average(em => em.Salary),
                 Emplooyes = gr
             })
             .OrderByDescending(gr => gr.AverageSalary)
             .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {depart.Name}");
        foreach (var emp in depart.Emplooyes.OrderByDescending(em => em.Salary))
        {
            Console.WriteLine($"{emp.Name} {emp.Salary:f2} {emp.Email} {emp.Age}");
        }
    }
}

