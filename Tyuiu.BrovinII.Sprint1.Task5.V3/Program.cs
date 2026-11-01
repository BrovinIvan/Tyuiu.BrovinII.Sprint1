using Tyuiu.BrovinII.Sprint1.Task5.V3.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 1");
            Console.WriteLine("Вариант 3");
            Console.WriteLine("Задание 5");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите число: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.Calculate(x));
            Console.ReadLine();
        }
    }
}
