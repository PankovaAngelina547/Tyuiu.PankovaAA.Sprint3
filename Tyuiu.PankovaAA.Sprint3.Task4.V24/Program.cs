using Tyuiu.PankovaAA.Sprint3.Task4.V24.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task4.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #3                                                              *");
            Console.WriteLine("*  Тема: использование операторов continue и break в циклах               *");
            Console.WriteLine("*  Задание #04                                                            *");
            Console.WriteLine("*  Вариант #24                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  УСЛОВИЕ:                                                               *");
            Console.WriteLine("*  На отрезке, где x принимает значения от -5 до 5, вычислить значение    *");
            Console.WriteLine("*  функции При х = 0 прервать цикл. Полученные значения перемножать.      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");
            
            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine($"Произведение ряда = {result:F3}");
            Console.ReadKey();


        }

    }
}
