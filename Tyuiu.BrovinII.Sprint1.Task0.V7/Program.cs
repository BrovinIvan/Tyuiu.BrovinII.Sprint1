using Tyuiu.BrovinII.Sprint1.Task0.V7.Lib;
namespace Tyuiu.BrovinII.Sprint1.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 1");
            Console.WriteLine("Вариант 7");
            Console.WriteLine("Задание 0");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Исходные данные: 18/6*2 - (4-3)");
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.Calculate());
        }
    }
}
