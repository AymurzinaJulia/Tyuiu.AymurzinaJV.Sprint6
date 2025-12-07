using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AymurzinaJV.Sprint6.Task1.V17.Lib
{
    public class DataService : ISprint6Task1V17
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] nums = new double[len];
            int index = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((Math.Sin(x) - 3 + x) == 0) nums[index] = 0;
                else nums[index] = Math.Round((3 * x - 1.5) / (Math.Sin(x) - 3 + x) + 2, 2);
                index++;
            }
            return nums;
        }
    }
}
