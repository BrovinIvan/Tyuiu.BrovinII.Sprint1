using Tyuiu.BrovinII.Sprint1.Task1.V28.Lib;
namespace Tyuiu.BrovinII.Sprint1.Task1.V28
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Спринт 1");
            Console.WriteLine("Вариант 7");
            Console.WriteLine("Задание 1");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Исходные данные: (x*2)/(1+x)");
            Console.WriteLine("Введите число: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.Calculate(x));

        }
    }
}
