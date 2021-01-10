using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git41
{
    class Program
    {
        static void Main(string[] args)
        {

            char again = 'д';
            while (again == 'д')
            {
                double a;
                double b;
                double equally;
                char oper;






                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());



                Console.WriteLine("Введите симво(+,-,/,*):");
                oper = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());


                if (oper == '+')
                {
                    equally = a + b;
                    Console.WriteLine("Ответ: " + equally);
                }


                else if (oper == '-')
                {
                    equally = a - b;
                    Console.WriteLine("Ответ: " + equally);
                }


                else if (oper == '*')
                {
                    equally = a * b;
                    Console.WriteLine("Ответ: " + equally);
                }


                else if (oper == '/')
                {
                    equally = a / b;
                    Console.WriteLine("Ответ: " + equally);
                }
                else
                {
                    Console.WriteLine("Неизвестный оператор.");
                }
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());

            }
        }
    }
}
