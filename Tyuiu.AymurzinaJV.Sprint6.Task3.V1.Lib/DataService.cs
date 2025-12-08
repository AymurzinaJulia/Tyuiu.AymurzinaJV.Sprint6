using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AymurzinaJV.Sprint6.Task3.V1.Lib
{
    public class DataService : ISprint6Task3V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int count = 0;

        
            for (int numRow = 0; numRow < rows - 1; numRow++)
            {
                int minRow = numRow;
                for (int j = numRow + 1; j < rows; j++)
                {
                    if (matrix[j, count] < matrix[minRow, count])
                    {
                        minRow = j;
                    }
                }
                int temp = matrix[numRow, count];
                matrix[numRow, count] = matrix[minRow, count];
                matrix[minRow, count] = temp;
            }
            return matrix;
        }
    }
}
