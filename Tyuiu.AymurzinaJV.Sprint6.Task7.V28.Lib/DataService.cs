using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AymurzinaJV.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] nums = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    nums[i, j] = Convert.ToInt32(line_r[j]);
                    if (nums[i, j] != 13 && i == 6)
                    {
                        nums[i, j] = 0;
                    }
                }
            }
            return nums;
        }
    }
}
