﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VumaR.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = Math.Log(((double)x + 1) / ((double)x + 2));
            z = Math.Round(z, 3);
            File.WriteAllText(filePath, Convert.ToString(z));
            return filePath;
        }
    }
}
