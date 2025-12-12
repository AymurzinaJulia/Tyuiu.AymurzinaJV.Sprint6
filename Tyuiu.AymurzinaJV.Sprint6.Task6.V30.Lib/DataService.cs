using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AymurzinaJV.Sprint6.Task6.V30.Lib
{
    public class DataService : ISprint6Task6V30
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    string[] words = line.Split(' ');
                    if (words.Length > 3)
                    {
                        res += words[3] + ' ';
                    }
                }
            }
            res = res.Trim();
            return res;
        }
    }
}
