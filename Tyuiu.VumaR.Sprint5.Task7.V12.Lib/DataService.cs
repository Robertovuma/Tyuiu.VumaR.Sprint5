using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.VumaR.Sprint5.Task7.V12.Lib
{
    public class DataService : ISprint5Task7V12
    {
        public string LoadDataAndSave(string path)
        {
            string pathSafeFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V28.txt");
            FileInfo fileInfo = new FileInfo(pathSafeFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSafeFile);
            }

            string strline = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++) // исправленная строка
                    {
                        char c = line[i]; //исправленная строка
                        if ((c >= 'a') && (c <= 'z')) // проверяем если символ маленькая буква
                        {
                            strline += char.ToUpper(c); // если маленькая - то в большую
                        }
                        else
                        {
                            strline += c; //иначе без изменений
                        }
                    }
                    File.AppendAllText(pathSafeFile, strline + Environment.NewLine);
                    strline = "";
                }
            }

            return pathSafeFile;
        }
    }
}
