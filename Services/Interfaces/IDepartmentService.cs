using APIDocfx.Models;

namespace APIDocfx.Services.Interfaces
{
    /// <summary>
    /// Інтерфейс для сервісу роботи з відділами.
    /// </summary>
    public interface IDepartmentService
    {
        /// <summary>
        /// Додає новий відділ в систему.
        /// </summary>
        /// <param name="department">Відділ для додавання.</param>
        void AddDepartment(Department department);

        /// <summary>
        /// Отримує відділ за його ідентифікатором.
        /// </summary>
        /// <param name="departmentId">Ідентифікатор відділу.</param>
        /// <returns>Знайдений відділ.</returns>
        Department GetDepartmentById(int departmentId);
    }
}
