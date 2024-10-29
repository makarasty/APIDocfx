using APIDocfx.Models;

namespace APIDocfx.Services.Interfaces
{
    /// <summary>
    /// Інтерфейс для сервісу роботи зі співробітниками.
    /// </summary>
    public interface IEmployeeService
    {
        /// <summary>
        /// Додає нового співробітника в систему.
        /// </summary>
        /// <param name="employee">Співробітник для додавання.</param>
        void AddEmployee(Employee employee);

        /// <summary>
        /// Отримує співробітника за його ідентифікатором.
        /// </summary>
        /// <param name="employeeId">Ідентифікатор співробітника.</param>
        /// <returns>Знайдений співробітник.</returns>
        Employee GetEmployeeById(int employeeId);

        /// <summary>
        /// Оновлює інформацію про співробітника.
        /// </summary>
        /// <param name="employee">Співробітник з оновленою інформацією.</param>
        void UpdateEmployee(Employee employee);
    }
}
