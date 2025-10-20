using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PankovaAA.Sprint3.Task0.V4.Lib
{
    public class DataService : ISprint3Task0V4
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiply = 1;

            for (int k = 1; k <= 7; k++)
            {
                multiply *= Math.Sin(0.1) + k;
            }

            return Math.Round(multiply, 3);
        }
    }
}

