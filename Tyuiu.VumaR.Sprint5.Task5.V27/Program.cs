using Tyuiu.VumaR.Sprint5.Task5.V27.Lib;
namespace Tyuiu.VumaR.Sprint5.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DataService ds = new DataService();
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V27.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Среднее значение всех чисел кратных пяти = " + res);
            Console.ReadKey();
        }
    }
}
