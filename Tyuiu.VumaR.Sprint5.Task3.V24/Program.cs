using Tyuiu.VumaR.Sprint5.Task3.V24.Lib;
namespace Tyuiu.VumaR.Sprint5.Task3.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine("x = " + x);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                   *");
            Console.WriteLine("********************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.WriteLine(Math.Round(6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x, 3));
            Console.ReadKey();
        }
    }
}
