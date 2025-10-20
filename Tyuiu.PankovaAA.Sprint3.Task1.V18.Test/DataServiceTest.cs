using Tyuiu.PankovaAA.Sprint3.Task1.V18.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task1.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(startValue, stopValue);
            double wait = 0.121;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
