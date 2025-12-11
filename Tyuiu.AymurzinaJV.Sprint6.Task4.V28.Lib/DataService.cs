using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AymurzinaJV.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] nums = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2.5 == 0) nums[count] = 0;
                else
                {
                    nums[count] = Math.Round((Math.Cos(2 * x) + ((Math.Sin(x)) / (x + 2.5)) + 2 * x), 2);
                }
              
                count++;

            }
          
            return nums;
        }
    }
}
