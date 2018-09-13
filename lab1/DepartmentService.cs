﻿using System;
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
        {
            int departmentsNumber = File.ReadAllLines("D:\\7 сем\\РИС\\departments.txt").Length;

            Console.WriteLine("Введите название: ");
            String title = Console.ReadLine();

            FileStream fstr = new FileStream("D:\\7 сем\\РИС\\departments.txt", FileMode.OpenOrCreate, FileAccess.Write);
            fstr.Seek(0, SeekOrigin.End);
            StreamWriter sw = new StreamWriter(fstr);

            Department tempDepartment = new Department();
            tempDepartment.Id = departmentsNumber;
            tempDepartment.Title = title;

            sw.WriteLine(tempDepartment.Id + " " + tempDepartment.Title);
            sw.Close();
            fstr.Close();

            return true;
        }

        public void showAllDepartments()
        {
            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\departments.txt");
            int i = 0;
            for (i = 0; i < strArr.Length; i++)
            {
                Console.WriteLine(strArr[i]);
            }
            String[] array = strArr[i - 1].Split(' ');

            Console.WriteLine(array[array.Length-1] + "\n");
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        public void deleteDepartment(DepartmentService entity)
        {
            entity.showAllDepartments();
            Console.WriteLine("Какой департамент хотите удалить?\n Введите номер: ");
            String id = Console.ReadLine();


            String[] strArr = File.ReadAllLines("D:\\7 сем\\РИС\\departments.txt");
            strArr[int.Parse(id)] = String.Empty;

            File.WriteAllLines("D:\\7 сем\\РИС\\departments.txt", strArr);
        }
}