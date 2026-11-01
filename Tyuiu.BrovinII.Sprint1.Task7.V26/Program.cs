using Tyuiu.BrovinII.Sprint1.Task7.V26.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("Спринт 1");
            Console.WriteLine("Вариант 26");
            Console.WriteLine("Задание 7");
            Console.WriteLine("Выполнил Бровин Иван Ильич / ПКТБ-26-1");
            Console.WriteLine("Введите x:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y:");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("z:");
            Console.WriteLine(ds.Calculate(x,y));
            Console.ReadLine();
        }
    }
}
