using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Доп_задание
{
    class Program
    {
        static int Add(int summand1, int summand2)
        {
            return summand1 + summand2;
        }

        static int Sub(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        static int Mul(int factor1, int factor2)
        {
            return factor1 * factor2;
        }

        static double Div(int dividend, int divisor)
        {
            if (divisor != 0)
            {
                return (double)dividend / divisor;
            }
            
            Console.WriteLine("На нуль делить нельзя!");
            return 0; 
        }

        static void Main(string[] args)
        {
            Label:
            Console.Write("Введите 1-е число: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите 2-е число: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знак арифметической операции");
            var sign = Console.ReadKey().KeyChar;
            
            switch (sign)
            {
                case '+':
                    {
                        int sum = Add(operand1, operand2);
                        Console.WriteLine("{0} + {1} = {2}", operand1, operand2, sum);
                        break;
                    }
                case '-':
                    {
                        int sub = Sub(operand1, operand2);
                        Console.WriteLine("{0} - {1} = {2}", operand1, operand2, sub);
                        break;
                    }
                case '*':
                    {
                        int mul = Mul(operand1, operand2);
                        Console.WriteLine("{0} * {1} = {2}", operand1, operand2, mul);
                        break;
                    }
                case '/':
                    {
                        if (operand2 != 0)
                        {
                            double div = Div(operand1, operand2);
                            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, div);
                        }
                        else
                        {
                            double div = Div(operand1, operand2);
                            Console.WriteLine();
                        }    
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Вы ввели неправильную команду");
                        break;
                    }
            }

            Console.WriteLine("Хотите-ли Вы выполнить еще одну операцию? y/n");
            string answer = Convert.ToString(Console.ReadLine());                       

            if (answer.Equals("y"))
            {
                goto Label;
            }
            else
            {
                Console.WriteLine("До свидания!");
            }  

            Console.ReadKey();
        }
    }
}
