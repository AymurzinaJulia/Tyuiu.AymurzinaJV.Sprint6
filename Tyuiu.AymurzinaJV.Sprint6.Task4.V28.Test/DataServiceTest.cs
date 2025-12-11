using Tyuiu.AymurzinaJV.Sprint6.Task4.V28.Lib;

namespace Tyuiu.AymurzinaJV.Sprint6.Task4.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double[] wait = new double[] { -11.22, -8.65, -4.76, -6.47, -2.98, 1, 1.82, 3.55, 6.99, 7.74, 9.03 };
          
            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
