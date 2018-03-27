using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calkulyshka
{


    class Program
    {

        static double a;
        static double b;
        static double result;
        static char oper;
        static char again = 'д';


        public static void Main(string[] args)
        {

            Starting();

        }


        public static void Starting()
        {

            Hi();
            while (again == 'д')
            {


                Entering();
                Operation();
                Console.WriteLine("Вы хотите продолжить работу с калькулятором? (д/н)");
                again = Convert.ToChar(Console.ReadLine());
            }

        }



        public static void Hi()
        {
            Console.WriteLine("Привет. Вы запустили Калькуляшку.");
        }


        public static void Entering()
        {
            Console.WriteLine("Ввидите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ввидите оператор:");
            oper = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ввидите второе число:");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public static void Operation()
        {

            if (oper == '+')
            {
                result = a + b;
                Console.WriteLine("Cумма " + a + " и " + b + " равна " + result + ".");
            }

            else if (oper == '-')
            {
                result = a - b;
                Console.WriteLine("Разность " + a + " и " + b + " равна " + result + ".");
            }

            else if (oper == '*')
            {
                result = a * b;
                Console.WriteLine("Умножение " + a + " на " + b + " равно " + result + ".");
            }

            else if (oper == '/')
            {
                result = a / b;
                Console.WriteLine("Деление " + a + " на " + b + " равно " + result + ".");
            }
            else
            {
                Console.WriteLine("Неизвестная хрень вместо оператора.");

            }
        }
    }


}
