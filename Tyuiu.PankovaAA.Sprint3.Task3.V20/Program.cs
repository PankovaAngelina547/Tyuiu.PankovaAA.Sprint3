using Tyuiu.PankovaAA.Sprint3.Task3.V20.Lib;
namespace Tyuiu.PankovaAA.Sprint3.Task3.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Панькова А.А.| ПИНб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Спринт #3                                                              *");
            Console.WriteLine("*  Тема: использование цикла foreach                                      *");
            Console.WriteLine("*  Задание #03                                                            *");
            Console.WriteLine("*  Вариант #20                                                            *");
            Console.WriteLine("*  Выполнила: Панькова Ангелина Алексеевна    |ПИНб-25-1|                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  Используя цикл foreach подсчитать количество букв “f” в строке: gfft   *");
            Console.WriteLine("*   ntf f opf                                                             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  ИСХОДНЫЕ ДАННЫЕ:                                                       *");


            string str = "gfft ntf f opf";
            char ch = 'f';

            Console.WriteLine("Строка = " + str);
            Console.WriteLine("Искомый символ = " + ch);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*  РЕЗУЛЬТАТ:                                                             *");

            int result = ds.GetCharCount(str, ch);
            Console.WriteLine("Количество символов '" + ch + "' = " + result);
            Console.ReadKey();

        }

    }
}
