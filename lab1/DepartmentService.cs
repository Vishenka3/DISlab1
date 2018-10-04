using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class DepartmentService
    {
        public bool addDepartment()
        {// D:\\7 сем\\РИС\\departments.txt
            int departmentsNumber = File.ReadAllLines("D:\\univ\\DISLab1\\departments.txt").Length;

            Console.WriteLine("Введите название: ");
            String title = Console.ReadLine();

            FileStream fstr = new FileStream("D:\\univ\\DISLab1\\departments.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fstr.Seek(0, SeekOrigin.End);
            StreamWriter sw = new StreamWriter(fstr);

            Department tempDepartment = new Department();
  
            tempDepartment.Title = title;
            tempDepartment.WorkersNumber = 0;

            sw.WriteLine(tempDepartment.Title);
            sw.Close();
            fstr.Close();

            return true;
        }

        public void showAllDepartments()
        {
            String[] strArr = File.ReadAllLines("D:\\univ\\DISLab1\\departments.txt");
            int i = 0;
            for (i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
        }

        public void sortAllDepartments()
        {
            String[] strArr = File.ReadAllLines("D:\\univ\\DISLab1\\departments.txt");

            Array.Sort(strArr);

            for (int i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
                // Console.WriteLine("\n");
            }
        }

        public void deleteDepartment(DepartmentService entity)
        {
            entity.showAllDepartments();
            Console.ReadKey();
            Console.WriteLine("Какой департамент хотите удалить?\n Введите номер: ");
            String id = Console.ReadLine();


            String[] strArr = File.ReadAllLines("D:\\univ\\DISLab1\\departments.txt");
            strArr[int.Parse(id)] = String.Empty;

            File.WriteAllLines("D:\\univ\\DISLab1\\departments.txt", strArr);
        }
    }
}
