using Tyuiu.PankovaAA.Sprint3.Task7.V30.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task7.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #3                                                              *");
            Console.WriteLine("*  Тема: добавление к решению иоговых проектов по спринту                 *");
            Console.WriteLine("*  Задание #07                                                            *");
            Console.WriteLine("*  Вариант #30                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");


            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = ds.GetMassFunction(startValue, stopValue);



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}   | {1,6:f2} |", startValue, valueArray[i]);
                startValue++;
            }
            Console.ReadKey();

        }

    }
}
