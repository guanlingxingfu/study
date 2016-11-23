using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007冒泡排序拓展
{
    class Program
    {

        static void Sort(int[] sortArray)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;

                    }
                }
            } while (swapped);
        }

        static void CommonSort<T>(T[] sortArray,Func<T,T,bool> compareMethod)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i],sortArray[i+1]))
                    {
                        T temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;

                    }
                }
            } while (swapped);
        }
        static void Main(string[] args)
        {
            //int[] sortArray = new int[] { 321, 4354, 65, 76, 34, 21 };
            //Sort(sortArray);
            //foreach(var temp in sortArray)
            //{
            //    Console.Write(temp + " ");
            //}

            Employee[] employees = new Employee[]
            {
                new Employee("dsf",12),
                new Employee("543ddf",214),
                new Employee("fdsf3",14),
                new Employee("fsf21",65),
                new Employee("f32sf21",6553)
            };

            CommonSort<Employee>(employees, Employee.Compare);
            foreach(Employee em in employees)
            {
                Console.WriteLine(em);
            }

            Console.ReadKey();

        }
    }
}
