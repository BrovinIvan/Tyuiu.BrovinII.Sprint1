using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BrovinII.Sprint1.Task5.V3.Lib
{
    public class DataService : ISprint1Task5V3
    {
        public int Calculate(int k)
        {
            string kStr = k.ToString();

            if (kStr.Length >= 3)
            {
                int h = kStr[kStr.Length - 3] - '0';
                return h;
            }
            else
            {
                return 0;
            }
        }
    }
}
