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
