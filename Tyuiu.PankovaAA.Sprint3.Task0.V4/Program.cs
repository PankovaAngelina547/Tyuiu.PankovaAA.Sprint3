using Tyuiu.PankovaAA.Sprint3.Task0.V4.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #2                                                              *");
            Console.WriteLine("*  Тема: Оператор цикла for                                               *");
            Console.WriteLine("*  Задание #00                                                            *");
            Console.WriteLine("*  Вариант #04                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу используя цикл for, которая вычисляет произведение  *");
            Console.WriteLine("*  ряда по формуле p = ∏[k=1 to 7] (sin(0.1) + k)                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            int startValue = 1;
            int stopValue = 7;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            double result = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            Console.WriteLine($"Произведение ряда = {result}");
            Console.ReadKey();

            Console.WriteLine("***************************************************************************");
        }

    }
}
