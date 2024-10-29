namespace APIDocfx.Enums
{
    /// <summary>
    /// Статус співробітника.
    /// </summary>
    public enum EmployeeStatus
    {
        /// <summary>
        /// Співробітник активний.
        /// </summary>
        Active,

        /// <summary>
        /// Співробітник звільнений.
        /// </summary>
        Terminated,

        /// <summary>
        /// Співробітник у відпустці.
        /// </summary>
        OnLeave
    }

    /// <summary>
    /// Тип зайнятості співробітника.
    /// </summary>
    public enum EmploymentType
    {
        /// <summary>
        /// Повна зайнятість.
        /// </summary>
        FullTime,

        /// <summary>
        /// Неповна зайнятість.
        /// </summary>
        PartTime,

        /// <summary>
        /// Контрактна основа.
        /// </summary>
        Contract
    }
}
