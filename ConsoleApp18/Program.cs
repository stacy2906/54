using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводим переменную
            Console.Write("Введите количество сотрудников: ");
            int N = Convert.ToInt32(Console.ReadLine());

            // Создаем массив из N объектов Employee
            Employee[] employees = new Employee[N];

            for (int i = 0; i < N; i++)
            {
                employees[i] = new Employee();

                // Вводим информацию о каждом сотруднике
                Console.Write("Введите табельный номер: ");
                employees[i].EmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите полное имя сотрудника:");
                employees[i].FullName = Console.ReadLine();
                Console.Write("Введите дату рождения сотрудника (yyyy/mm/dd): ");
                employees[i].DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.Write("Введите должность сотрудника: ");
                employees[i].Position = Console.ReadLine();
                Console.Write("Введите оклад сотрудника:  ");
                employees[i].Salary = Convert.ToInt32(Console.ReadLine());
            }

            // Выводим информацию о сотрудниках в табличном виде
            Console.WriteLine("\nИнформация о сотрудниках");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("Табельный номер\tФИО\tДата рождения\tДолжность\tОклад");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{employees[i].EmployeeId}\t\t{employees[i].FullName}\t{employees[i].DateOfBirth.ToShortDateString()}\t{employees[i].Position}\t{employees[i].Salary}");
            }
            if (N == 0)
            {
                Console.WriteLine("Информация о сотрудниках отсутствует.");
            }

            // Выводим информацию о возрасте каждого сотрудника
            Console.WriteLine("\nВозраст сотрудников");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("ФИО\tТекущий возраст");
            Console.WriteLine("--------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"{employees[i].FullName}\t{employees[i].CalculateAge()}");
            }
            if (N == 0)
            {
                Console.WriteLine("Информация о возрасте сотрудниках отсутствует.");
            }
            Console.ReadKey();
        }
    }
}
   
