using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PankovaAA.Sprint3.Task1.V18.Lib
{
    public class DataService : ISprint3Task1V18
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sum = 0;
            int i = startValue;

            while (i <= stopValue)
            {
                sum += Math.Sin(i) * Math.Pow(1.0 / 4, 2);
                i++;
            }

            return Math.Round(sum, 3); 
        }
    }
}
