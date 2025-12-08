using Tyuiu.AymurzinaJV.Sprint6.Task3.V1.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task3.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mtrx = { { 25, 20, 28, 2, 6},
                            { 19, 9, 18, -7, 24},
                            { 21, 16, 5, -7, -8},
                            { 30, -13, 1, -15, 2 },
                            { 31, 9, -3, -9, -18 } };
            int[,] res = ds.Calculate(mtrx);
            int[,] wait = { { 19, 20, 28, 2, 6},
                          { 21, 9, 18, -7, 24},
                          { 25, 16, 5, -7, -8},
                          { 30, -13, 1, -15, 2 },
                          { 31, 9, -3, -9, -18 } };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
