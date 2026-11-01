using System;
using System.Linq;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.BrovinII.Sprint1.Task6.V15.Lib
{
    public class DataService : ISprint1Task6V15
    {
        public bool CheckLettersCount(string value)
        {
            return value.Count(char.IsLetter) > value.Count(char.IsPunctuation);
        }
    }
}
