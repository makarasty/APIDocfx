using System;
using APIDocfx.Enums;
using APIDocfx.Models;
using APIDocfx.Services;

namespace APIDocfx
{
    /// <summary>
    /// Головний клас програми.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входу в програму.
        /// </summary>
        static void Main(string[] args)
        {
            // Приклад використання сервісів
            var employeeService = new EmployeeService();
            var departmentService = new DepartmentService();

            var department = new Department
            {
                DepartmentId = 1,
                Name = "Відділ кадрів"
            };

            departmentService.AddDepartment(department);

            var employee = new Employee
            {
                EmployeeId = 1,
                FullName = "Іван Іванов",
                Department = department,
                Position = new Position { Title = "Менеджер з персоналу", Salary = 50000 },
                Status = EmployeeStatus.Active,
                EmploymentType = EmploymentType.FullTime
            };

            employeeService.AddEmployee(employee);

            Console.WriteLine("Співробітника успішно додано.");
        }
    }
}
