using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PankovaAA.Sprint3.Task5.V30.Lib
{
    public class DataService : ISprint3Task5V30
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            for (int k = startValue1; k <= stopValue1; k++)
            {
                double term = (11.0 / 2) * Math.Pow(x, 3) - k + x;
                sumSeries += term;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
