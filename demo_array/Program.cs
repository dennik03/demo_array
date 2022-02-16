using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // объявим и проинициализируем массив целых чисел
            int[] myarr = new int[] { 5, 4, 1, 7, 2, 100 , 44, 12, 4, 6 };
            // выведем длину массива
            Console.Write("Длина массива: ");
            Console.WriteLine(myarr.Length);
            Console.WriteLine("выведем 3-ий элемент массива");
            Console.WriteLine(myarr[2]);
            Console.WriteLine("выведем массив"); // чтобы пройти по всему массиву - нужен цикл
            for (int i = 0; i < myarr.Length; i++)
            {
                Console.WriteLine(myarr[i]);
            }
            Console.WriteLine("выведем только четные элементы и их индексы");
            int max = int.MinValue;
            int index = 0;
            for (int i = 0; i < myarr.Length; i++)
            {
                if (myarr[i] % 2 == 0)
                {
                    Console.WriteLine($"{i}-ый элемент равен {myarr[i]} ");
                }
                if (myarr[i]>max)
                {
                    max = myarr[i];
                    index = i;
                }

            }

            Console.WriteLine($"{max} - максимальный, {index} - его индекс в массиве, {index+1} - порядковый номер");
            Console.WriteLine(myarr.Length);
        }
    }
}
