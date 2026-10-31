using Tyuiu.BrovinII.Sprint1.Task2.V19.Lib;
namespace Tyuiu.BrovinII.Sprint1.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 1");
            Console.WriteLine("Вариант 7");
            Console.WriteLine("Задание 2");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Исходные данные: дюймы в метры");
            Console.WriteLine("Введите расстояние в дюймах: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат:");
            Console.WriteLine(ds.ConvertInchToKm(x));
        }
    }
}
