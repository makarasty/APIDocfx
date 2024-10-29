namespace APIDocfx.Models
{
    /// <summary>
    /// Клас, що представляє відділ організації.
    /// </summary>
    public class Department
    {
        /// <summary>
        /// Унікальний ідентифікатор відділу.
        /// </summary>
        public int DepartmentId { get; set; }

        /// <summary>
        /// Назва відділу.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Список співробітників у відділі.
        /// </summary>
        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
