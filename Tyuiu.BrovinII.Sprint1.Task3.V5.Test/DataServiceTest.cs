using Tyuiu.BrovinII.Sprint1.Task3.V5.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.DistanceLength(x, y);
            Assert.AreEqual (6, res);
        }
    }
}
