using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Employee
    {
        // Поля класса
        public int EmployeeId;
        public string FullName;
        public DateTime DateOfBirth;
        public string Position;     
        public int Salary;

        // Метод для вычисления возраста сотрудника
        public int CalculateAge()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - DateOfBirth.Year;
            if (currentDate < DateOfBirth.AddYears(age))
            {
                age--;
            }
            return age;
        }
    }
}
