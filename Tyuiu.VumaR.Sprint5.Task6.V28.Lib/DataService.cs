﻿
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VumaR.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        int ISprint5Task6V28.LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lines = line.Split(' ');
                    foreach (string c in lines)
                    {
                        int num;
                        if (Int32.TryParse(c, out num) && num > 999 && num < 10000)
                        {
                            count += 1;
                        }
                    }
                }
            }
            return count;
        }
    }
}
