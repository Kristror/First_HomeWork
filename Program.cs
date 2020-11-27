using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Домашняя работа Безукладникова Даниила

            Questionnaire();

            BMI();

            Dots();

            TwoVariables();

            Console.ReadKey();
        }
        private static void Questionnaire()
        {
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост в сантиметрах:");
            double growth = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в килограммах:");
            double weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Ваши имя: " + name + ", фамилия: " + surname + ", возраст: " + age.ToString() + ", рост: " + growth.ToString() + " см, вес: " + weight.ToString() + " кг."); //вывод используя склеивание
            Console.WriteLine(String.Format("Ваши имя: {0}, фамилия: {1}, возраст: {2}, рост: {3} см, вес: {4} кг.", name, surname, age, growth, weight)); //используя форматированный вывод;
            Console.WriteLine($"Ваши имя: {name}, фамилия: {surname}, возраст: {age}, рост: {growth} см, вес: {weight} кг."); //используя вывод со знаком $
        }

        private static void BMI()
        {
            Console.WriteLine("Введите ваш рост в метрах:");
            double growth = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в килограммах:");
            double weight = Double.Parse(Console.ReadLine());

            double bni = weight / (growth * growth);

            Console.WriteLine($"При росте {growth} м и весе {weight} кг ваш  индекс массы тела: {Math.Round(bni, 2)}"); 
        }

        private static void Dots()
        {
            Console.WriteLine("Введите координаты превой точки");
            Console.Write("X:");
            double x1 = Double.Parse(Console.ReadLine());
            Console.Write("Y:");
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координаты второй точки");
            Console.Write("X:");
            double x2 = Double.Parse(Console.ReadLine());
            Console.Write("Y:");
            double y2 = Double.Parse(Console.ReadLine());
            double distance = Distance2dots(x1, y1, x2, y2);

            Console.WriteLine($"Расстояние между первой точкой с координатами X:{x1}, Y:{y1} и второй точкой с координатами X:{x2}, Y:{y2} равно: {Math.Round(distance, 2)}");
        }

        private static double Distance2dots(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private static void TwoVariables()
        {
            Console.WriteLine("Введите первую переменную:");
            int var1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите вторую переменную:");
            int var2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Значение var1: {var1}, значение var2: {var2}");
            Console.WriteLine("Обмен...");

            int var3 = var1;
            var1 = var2;
            var2 = var3;

            Console.WriteLine($"Значение var1: {var1}, значение var2: {var2}");
            Console.WriteLine("Обмен...");

            var1 = var1 + var2;
            var2 = var1 - var2;
            var1 = var1 - var2;

            Console.WriteLine($"Значение var1: {var1}, значение var2: {var2}");
            
        }
    }
}
