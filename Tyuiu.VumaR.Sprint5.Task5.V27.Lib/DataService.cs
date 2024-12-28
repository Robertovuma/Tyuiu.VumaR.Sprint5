
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VumaR.Sprint5.Task5.V27.Lib
{
    public class DataService : ISprint5Task5V27
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (Convert.ToDouble(line) % 5 == 0)
                    {
                        res += Convert.ToDouble(line);
                        count++;
                    }
                }
            }
            res /= count;
            return res;
        }
    }
}
