using Tyuiu.BrovinII.Sprint1.Task2.V19.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.ConvertInchToKm(x);
            Assert.AreEqual(0.050, res);
        }
    }
}
