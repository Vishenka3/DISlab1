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

            sw.WriteLine(tempWorker.Id + " " + tempWorker.Name + " " + tempWorker.Age + " " + tempWorker.Salary + "\n");
            sw.Close();
            fstr.Close();

            return true;
        }

        public void showAllWorkers() {
            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
                Console.WriteLine("\n");
            }
        }

        public void sortAllWorkers()
        {
            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");

            Array.Sort(strArr);

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
                Console.WriteLine("\n");
            }
        }

        public void deleteWorker(WorkerService entity)
        {
            entity.showAllWorkers();
            Console.ReadKey();
            Console.WriteLine("Какого работника хотите удалить?\n Введите номер: ");
            String id = Console.ReadLine();


            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");
            strArr[int.Parse(id)] = String.Empty;

            File.WriteAllLines("D:\\7 сем\\РИС\\workers.txt", strArr);
        }

        public void attacheWorkerToDepartment(DepartmentService entity, WorkerService workerEntity)
        {
            workerEntity.showAllWorkers();
            Console.WriteLine("Какого работника назначить?\n Введите номер: ");
            String workerId = Console.ReadLine();

            Console.WriteLine("В какой департамент?\n Введите номер: ");
            entity.showAllDepartments();
            String departmentId = Console.ReadLine();

            String[] workersArr = File.ReadAllLines("D:\\7 сем\\РИС\\workers.txt");
            String[] workerStringArray = workersArr[int.Parse(workerId)].Split(' ');

            String[] depsArr = File.ReadAllLines("D:\\7 сем\\РИС\\departments.txt");
            String[] depStringArray = depsArr[int.Parse(departmentId)].Split(' ');

            
            if (workerStringArray.Length != 5)
            {
                String changedWorker = String.Join(" ", workerStringArray) + " " + departmentId;
                workersArr[int.Parse(workerId)] = changedWorker;

                int number;
                Int32.TryParse(depStringArray[2], out number);
                number++;
                depStringArray[2] = number.ToString();

                String changedDep = String.Join(" ", depStringArray);
                depsArr[int.Parse(departmentId)] = changedDep;
            }
            else
            {
                Console.WriteLine("Работник уже назначен в департамент!\n");
            }
            Console.ReadKey();
            File.WriteAllLines("D:\\7 сем\\РИС\\workers.txt", workersArr);
            File.WriteAllLines("D:\\7 сем\\РИС\\departments.txt", depsArr);
        }
    }
}
