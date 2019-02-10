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

        static int[] SubArray(int[] array, int index, int count)
        {
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i * 2;
            //}

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
            Console.Write("Type oil count: ");
            var oil = Convert.ToInt32(Console.ReadLine());

            var car = new Car(0.1);
            Console.WriteLine("Km : " + car.ReturnDistance(oil));

            var car2 = new Car(0.2);
            Console.WriteLine("Km : " + car2.ReturnDistance(oil));



            //MyReverse(array);
            //Console.WriteLine(new string('-', 40));

            //Console.Write("Введите индекс, начиная с которого будут выводиться элементы массива: ");
            //int index = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Введите количество выводимых элементов: ");
            //int count = Convert.ToInt32(Console.ReadLine());

            ////array[0] = 100;
            ////array[1] = 110;
            ////array[2] = 130;
            ////array[3] = 140;

            //var newArray = SubArray(array, index, count);

            //Console.ReadKey();
        }
    }
}
