using Tyuiu.PankovaAA.Sprint3.Task1.V18.Lib;
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
            Console.WriteLine("*  Тема: Оператор цикла while                                             *");
            Console.WriteLine("*  Задание #01                                                            *");
            Console.WriteLine("*  Вариант #18                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  Написать программу используя цикл while, которая вычисляет сумму       *");
            Console.WriteLine("*  ряда по формуле p = ∏[k=1 to 7] (sin(0.1) + k)                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int startValue = 1;
            int stopValue = 15;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");
            double result = ds.GetSumSeries(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            Console.WriteLine($"Сумма ряда = {result}");
            Console.ReadKey();

            Console.WriteLine("***************************************************************************");
        }

    }
}
