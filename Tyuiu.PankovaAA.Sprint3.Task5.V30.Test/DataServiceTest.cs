using Tyuiu.PankovaAA.Sprint3.Task5.V30.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task5.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 1;
            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = 105;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
