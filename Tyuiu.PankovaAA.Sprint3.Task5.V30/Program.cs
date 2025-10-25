using Tyuiu.PankovaAA.Sprint3.Task5.V30.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task5.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #3                                                              *");
            Console.WriteLine("*  Тема: вложенные циклы                                                  *");
            Console.WriteLine("*  Задание #05                                                            *");
            Console.WriteLine("*  Вариант #30                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 1;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Сумма ряда = {result:F3}");
            Console.ReadKey();

        }

    }
}
