using Tyuiu.AymurzinaJV.Sprint6.Task6.V30.Lib;
namespace Tyuiu.AymurzinaJV.Sprint6.Task6.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string fullPath = @"C:\DataSprint6\InPutDataFileTask6V30.txt";

            FileInfo fileInfo = new FileInfo(fullPath);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
