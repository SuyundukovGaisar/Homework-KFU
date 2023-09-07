using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_02._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1: ");
            // часть a
            Console.WriteLine("Мир Труд Май");
            // часть b
            Console.WriteLine("Мир\n Труд \n    Май");

            Console.WriteLine("Задание 2: ");
            Console.WriteLine("Введите первое число:");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string number2 = Console.ReadLine();
            Console.WriteLine("{0}, {1}", number2, number1);

            Console.WriteLine("Задание 3: ");
            Console.WriteLine("Введите радиус: ");
            double R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Длина окружности равна: ");
            Console.WriteLine(2 * Math.PI * R);
            Console.WriteLine("Площадь круга равна: ");
            //возведение в степень
            double R1 = Math.Pow(R, 2);
            Console.WriteLine(Math.PI * R1);

            Console.WriteLine("Задание 4: ");
            Console.WriteLine("Введите градусную меру угла: ");
            double cos = Convert.ToDouble(Console.ReadLine());
            double cos1 = (cos * (Math.PI)) / 180;
            Console.WriteLine("Косинус в радианах = " + Math.Cos(cos1));

            Console.WriteLine("Задание 5: ");
            Console.WriteLine("Введите коэффициент a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент с: ");
            double c = Convert.ToDouble(Console.ReadLine());
            var D = Math.Pow(b, 2) - 4 * a * c;
            double x1, x2;
            if (D < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней ");
            }
            else
            {
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }
                else
                {
                    x1 = -b / (2 * a);
                    x2 = x1;
                }
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }

            Console.WriteLine("Задание 6: ");
            Console.WriteLine("Введите a: ");
            string а = Console.ReadLine();
            int а1 = Convert.ToInt32(а);
            int а2 = Convert.ToInt32(а);
            Console.WriteLine("Введите b: ");
            string б = Console.ReadLine();
            int б1 = Convert.ToInt32(б);
            int б2 = Convert.ToInt32(б);
            Console.WriteLine("Введите c: ");
            string с = Console.ReadLine();
            int с1 = Convert.ToInt32(с);
            int с2 = Convert.ToInt32(с);
            // пункт a
            int n = а1;
            а1 = б1;
            б1 = с1;
            с1 = n;
            Console.WriteLine("a): ");
            Console.WriteLine($"a = {а1}");
            Console.WriteLine($"b = {б1}");
            Console.WriteLine($"c = {с1}");
            Console.WriteLine("b): ");
            //пункт b
            int n1 = а2;
            а2 = с2;
            с2 = б2;
            б2 = n1;
            Console.WriteLine($"a = {а2}");
            Console.WriteLine($"b = {б2}");
            Console.WriteLine($"c = {с2}");

            Console.WriteLine("Задание 7: ");
            //Создание объекта для генерации чисел
            Random rnd = new Random();
            //Cлучайные числа
            int value = rnd.Next();
            int value1 = rnd.Next();
            int value2 = rnd.Next();
            int value3 = rnd.Next();
            Console.WriteLine(value);
            Console.WriteLine(value1);
            Console.WriteLine(value2);
            Console.WriteLine(value3);

            Console.WriteLine("Задание 8: ");
            Console.WriteLine("Введите трёхзначное число: ");
            var count = Console.ReadLine();
            Console.WriteLine($"{count[2]}{count[0]}{count[1]}");

            Console.WriteLine("Задание 9: ");
            Console.WriteLine("Введите цену за кг и сколько кг конфет куплено(через enter): ");
            double price_candy = Convert.ToDouble(Console.ReadLine());
            double х = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену за кг и сколько кг печенья куплено(через enter): ");
            double price_candy1 = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену за кг и сколько кг яблок куплено(через enter): ");
            double price_candy2 = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            double х1 = х * price_candy;
            double y1 = y * price_candy1;
            double z1 = z * price_candy2;
            double result = х1 + y1 + z1;
            Console.WriteLine("Стоимость всей покупки равна " + result);


        }
    }
}
