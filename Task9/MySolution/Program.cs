using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySolution
{
    class Program
    {
        static void MyReverse(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i]);
            }
        }

        static int[] SubArray(ref int[] array, int index, int count)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }

            if (index + count < array.Length)
            {
                for (int i = index; i < count + index; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }
            else
            {
                for (int i = index; i < count + index; i++)
                {
                    if (i < array.Length)
                    {
                        Console.WriteLine(array[i]);
                    }
                    else
                    {
                        Console.WriteLine(1);
                    }
                }
            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            MyReverse(array);
            Console.WriteLine(new string('-', 40));

            Console.Write("Введите индекс, начиная с которого будут выводиться элементы массива: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество выводимых элементов: ");
            int count = Convert.ToInt32(Console.ReadLine());

            SubArray(ref array, index, count);

            Console.ReadKey();
        }
    }
}
