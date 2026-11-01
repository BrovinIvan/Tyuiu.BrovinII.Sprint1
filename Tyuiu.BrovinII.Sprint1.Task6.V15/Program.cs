using Tyuiu.BrovinII.Sprint1.Task6.V15.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task6.V15
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
            Console.WriteLine("Введите строку: ");
            string x = Console.ReadLine();
            Console.WriteLine("в строке больше букв, чем знаков?:");
            Console.WriteLine(ds.CheckLettersCount(x));
            Console.ReadLine();
        }
    }
}
