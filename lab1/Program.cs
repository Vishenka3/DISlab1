using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        private String str;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Program.menu();
            }

            Console.ReadKey();
        }

        public static void menu()
        {
            Console.WriteLine("Выберете пункт меня:");

            Console.WriteLine("1: Добавить подразделение");
            Console.WriteLine("2: Добавить сотрудника");
            Console.WriteLine("3: Удалить подразделение");
            Console.WriteLine("4: Удалить сотрудника");
            Console.WriteLine("5: Показать все подразделения");
            Console.WriteLine("6: Показать всех сотрудников");
            Console.WriteLine("7: Назначит сотрудника в отдел");

            String choice = Console.ReadLine();
            WorkerService workerService = new WorkerService();
            DepartmentService departmentService = new DepartmentService();

            switch (choice)
            {
                case "1":
                    {
                        departmentService.addDepartment();
                        break;
                    }
                case "2":
                    {
                        workerService.addWorker();
                        break;
                    }
                case "3":
                    {
                        departmentService.deleteDepartment(departmentService);
                        break;
                    }
                case "4":
                    {
                        workerService.deleteWorker(workerService);
                        break;
                    }
                case "5":
                    {
                        departmentService.showAllDepartments();
                        break;
                    }
                case "6":
                    {
                        workerService.showAllWorkers();
                        break;
                    }
                case "7":
                    {
                        workerService.attacheWorkerToDepartment(departmentService, workerService);
                        break;
                    }
                default: break;
            }
        }
    }
}
