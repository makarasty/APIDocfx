using APIDocfx.Models;
using APIDocfx.Services.Interfaces;

namespace APIDocfx.Services
{
    /// <summary>
    /// Реалізація інтерфейсу IDepartmentService.
    /// </summary>
    public class DepartmentService : IDepartmentService
    {
        private readonly List<Department> departments = new List<Department>();

        /// <inheritdoc />
        public void AddDepartment(Department department)
        {
            departments.Add(department);
        }

        /// <inheritdoc />
        public Department GetDepartmentById(int departmentId)
        {
            return departments.FirstOrDefault(d => d.DepartmentId == departmentId);
        }
    }
}
