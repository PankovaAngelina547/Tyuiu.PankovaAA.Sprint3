using Tyuiu.PankovaAA.Sprint3.Task3.V20.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task3.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "gfft ntf f opf";
            char ch = 'f';
            int expected = 5;
            int actual = ds.GetCharCount(str, ch);
            Assert.AreEqual(expected, actual);
        }
    }
}
