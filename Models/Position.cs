namespace APIDocfx.Models
{
    /// <summary>
    /// Клас, що представляє посаду співробітника.
    /// </summary>
    public class Position
    {
        /// <summary>
        /// Назва посади.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Заробітна плата для цієї посади.
        /// </summary>
        public decimal Salary { get; set; }
    }
}
