using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PankovaAA.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1.0;
            int i = startValue;

            do
            {
                double term = 300 / (i + Math.Pow(value, i));
                product *= Math.Pow(term, i);
                i++;
            } while (i <= stopValue);

            return product;
        }
    }
}
            
       
