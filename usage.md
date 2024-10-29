# Приклади використання

```csharp
using PersonnelManagement.Models;
using PersonnelManagement.Services;

// Створення сервісів
var departmentService = new DepartmentService();
var employeeService = new EmployeeService();

// Створення нового відділу
var itDepartment = new Department
{
    DepartmentId = 2,
    Name = "Інформаційні Технології"
};

departmentService.AddDepartment(itDepartment);

// Створення нового співробітника
var newEmployee = new Employee
{
    EmployeeId = 2,
    FullName = "Олена Коваль",
    Department = itDepartment,
    Position = new Position { Title = "Розробник ПЗ", Salary = 90000 },
    Status = EmployeeStatus.Active,
    EmploymentType = EmploymentType.FullTime
};

employeeService.AddEmployee(newEmployee);

// Отримання співробітника за ідентифікатором
var employee = employeeService.GetEmployeeById(2);
Console.WriteLine($"Співробітник: {employee.FullName}, Відділ: {employee.Department.Name}");
```