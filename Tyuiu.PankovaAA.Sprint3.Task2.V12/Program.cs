using Tyuiu.PankovaAA.Sprint3.Task2.V12.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task0.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #3                                                              *");
            Console.WriteLine("*  Тема: Оператор цикла while                                             *");
            Console.WriteLine("*  Задание #02                                                            *");
            Console.WriteLine("*  Вариант #12                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу используя цикл do... while, которая вычисляет       *");
            Console.WriteLine("*  произведение  ряда по формуле p = ∏[k=1 to 7] (sin(0.1) + k)           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            Console.WriteLine($"Значение x = {value}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine($"Произведение ряда = {result:F3}");
            Console.ReadKey();

            Console.WriteLine("***************************************************************************");
        }

    }
}
