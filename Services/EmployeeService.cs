using APIDocfx.Models;
using APIDocfx.Services.Interfaces;

namespace APIDocfx.Services
{
    /// <summary>
    /// Реалізація інтерфейсу IEmployeeService.
    /// </summary>
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> employees = new List<Employee>();

        /// <inheritdoc />
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        /// <inheritdoc />
        public Employee GetEmployeeById(int employeeId)
        {
            return employees.FirstOrDefault(e => e.EmployeeId == employeeId);
        }

        /// <inheritdoc />
        public void UpdateEmployee(Employee employee)
        {
            // Логіка оновлення співробітника
            throw new NotImplementedException();
        }
    }
}
