using Tyuiu.BrovinII.Sprint1.Task6.V15.Lib;

namespace Tyuiu.BrovinII.Sprint1.Task6.V15.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string a = "adfgadfg...";
            Assert.AreEqual(true, ds.CheckLettersCount(a));
        }
    }
}
