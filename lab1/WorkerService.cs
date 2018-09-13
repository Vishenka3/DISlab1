using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class WorkerService
    {
        public bool addWorker () {
            int workersNumber = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt").Length;

            Console.WriteLine("Введите имя: ");
            String name = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            String age = Console.ReadLine();
            Console.WriteLine("Введите зарплату: ");
            String salary = Console.ReadLine();

            
            FileStream fstr = new FileStream("D:\\7 сем\\РИС\\workers.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fstr.Seek(0, SeekOrigin.End);
            StreamWriter sw = new StreamWriter(fstr);

            Worker tempWorker = new Worker();
            tempWorker.Id = workersNumber;
            tempWorker.Name = name;
            tempWorker.Age = int.Parse(age);
            tempWorker.Salary = int.Parse(salary);

            sw.WriteLine(tempWorker.Id + " " + tempWorker.Name + " " + tempWorker.Age + " " + tempWorker.Salary);
            sw.Close();
            fstr.Close();

            return true;
        }

        public void showAllWorkers() {
            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        public void deleteWorker(WorkerService entity)
        {
            entity.showAllWorkers();
            Console.WriteLine("Какого работника хотите удалить?\n Введите номер: ");
            String id = Console.ReadLine();


            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");
            strArr[int.Parse(id)] = String.Empty;

            File.WriteAllLines("D:\\7 сем\\РИС\\workers.txt", strArr);
        }

        public void attacheWorkerToDepartment(DepartmentService entity, WorkerService workerEntity)
        {
            workerEntity.showAllWorkers();
            Console.WriteLine("Какого работника хотите удалить?\n Введите номер: ");
            String id = Console.ReadLine();


            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");
            strArr[int.Parse(id)] = String.Empty;

            File.WriteAllLines("D:\\7 сем\\РИС\\workers.txt", strArr);
        }
    }
}
