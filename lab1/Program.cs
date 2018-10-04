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
            Console.WriteLine("Выберете пункт меню:");

            Console.WriteLine("1: Работа с сотрудниками");
            Console.WriteLine("2: Работа с дапартаментами");
            Console.WriteLine("0: Выход");

            String choice = Console.ReadLine();
            WorkerService workerService = new WorkerService();
            DepartmentService departmentService = new DepartmentService();

            switch (choice)
            {
                case "1":
                    {
                        workersMenu();
                        break;
                    }
                case "2":
                    {
                        departmentMenu();
                        break;
                    }
                case "0":
                    {
                        System.Environment.Exit(1);
                        break;
                    }
                default: break;
            }
        }

        public static void workersMenu()
        {
            Console.WriteLine("Выберете пункт меню:");

            Console.WriteLine("1: Добавить сотрудника");
            Console.WriteLine("2: Удалить сотрудника");
            Console.WriteLine("3: Показать всех сотрудников");
            Console.WriteLine("4: Сортировка по фамилии");
            Console.WriteLine("5: Поиск по фамилии");
            Console.WriteLine("6: Назначит сотрудника в отдел");
            Console.WriteLine("0: Выход\n");

            String choice = Console.ReadLine();
            WorkerService workerService = new WorkerService();
            DepartmentService departmentService = new DepartmentService();

            switch (choice)
            {
                case "1":
                    {
                        workerService.addWorker();
                        break;
                    }
                case "2":
                    {
                        workerService.deleteWorker(workerService);
                        break;
                    }
                case "3":
                    {
                        workerService.showAllWorkers();
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        workerService.sortAllWorkers();
                        Console.ReadKey();
                        break;
                    }
                case "5":
                    {
                        workerService.findWorker();
                        Console.ReadKey();
                        break;
                    }
                case "6":
                    {
                        workerService.attacheWorkerToDepartment(departmentService, workerService);
                        break;
                    }
                case "0":
                    {
                        menu();
                        break;
                    }
                default: break;
            }
        }

        public static void departmentMenu()
        {
            Console.WriteLine("Выберете пункт меню:");

            Console.WriteLine("1: Добавить отдел");
            Console.WriteLine("2: Удалить отдел");
            Console.WriteLine("3: Показать все отделы");
            Console.WriteLine("4: Сортировка по названию");
            Console.WriteLine("5: Поиск по названию");
            Console.WriteLine("0: Выход\n");

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
                        departmentService.deleteDepartment(departmentService);
                        break;
                    }
                case "3":
                    {
                        departmentService.showAllDepartments();
                        Console.ReadKey();
                        break;
                    }
                case "4":
                    {
                        departmentService.sortAllDepartments();
                        Console.ReadKey();
                        break;
                    }
                case "5":
                    {
                        departmentService.findDepartment();
                        Console.ReadKey();
                        break;
                    }
                case "0":
                    {
                        menu();
                        break;
                    }
                default: break;
            }
        }
    }
}
