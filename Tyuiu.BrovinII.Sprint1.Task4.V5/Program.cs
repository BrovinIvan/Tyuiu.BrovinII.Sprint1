using Tyuiu.BrovinII.Sprint1.Task4.V5.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 1");
            Console.WriteLine("Вариант 5");
            Console.WriteLine("Задание 4");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите x: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите y: ");
            double y = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
