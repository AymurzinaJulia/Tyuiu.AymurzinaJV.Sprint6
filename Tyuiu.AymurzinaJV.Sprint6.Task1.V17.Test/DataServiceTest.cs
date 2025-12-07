using Tyuiu.AymurzinaJV.Sprint6.Task1.V17.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task1.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double[] wait = { 4.43, 4.16, 3.71, 3.27, 2.93, 2.5, 0.71, -47.61, 55.15, 45.17, 14.97};
            double[] res = ds.GetMassFunction(-5, 5);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
