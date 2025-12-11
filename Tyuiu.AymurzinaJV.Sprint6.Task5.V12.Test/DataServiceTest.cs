using Tyuiu.AymurzinaJV.Sprint6.Task5.V12.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task5.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string fullPath = @"C:\DataSprint6\InPutDataFileTask5V12.txt";

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
