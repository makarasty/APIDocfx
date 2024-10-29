using APIDocfx.Enums;

namespace APIDocfx.Models
{
    /// <summary>
    /// Клас, що представляє співробітника організації.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Унікальний ідентифікатор співробітника.
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// Повне ім'я співробітника.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Відділ, до якого належить співробітник.
        /// </summary>
        public Department Department { get; set; }

        /// <summary>
        /// Посада співробітника.
        /// </summary>
        public Position Position { get; set; }

        /// <summary>
        /// Статус співробітника.
        /// </summary>
        public EmployeeStatus Status { get; set; }

        /// <summary>
        /// Тип зайнятості співробітника.
        /// </summary>
        public EmploymentType EmploymentType { get; set; }
    }
}
