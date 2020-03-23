using System;
using System.Collections.Generic;
using DepartmentsEmployees.Data;
using DepartmentsEmployees.Models;

namespace DepartmentsEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository departmentRepo = new DepartmentRepository();

            EmployeeRepository employeeRepo = new EmployeeRepository();

            //Console.WriteLine("Employee report:");

            //List<Employee> allEmployeesWithDepartment = employeeRepo.GetAllEmployeesWithDepartment();

            //foreach (Employee emp in allEmployeesWithDepartment)
            //{
            //    Console.WriteLine($"{emp.Id} {emp.FirstName} {emp.LastName} {emp.Department.DeptName}");
            //}
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("1. Get all departments");
            Console.WriteLine("2. Get department by ID");
            Console.WriteLine("3. Add a department");
            Console.WriteLine("4. Update a department");
            Console.WriteLine("5. Delete a department");
            Console.WriteLine("6. Get all employees");
            Console.WriteLine("7. Get employee by ID");
            Console.WriteLine("8. Get employees with department");
            Console.WriteLine("9. Add a employee");
            Console.WriteLine("10. Update a employee");
            Console.WriteLine("11. Delete a employee");

            Console.WriteLine("\n-----------------------------------\n");




            Console.WriteLine("What operation would you like to perform?");
            Console.Write("> ");
            Console.ReadLine();
        }
    }
}
