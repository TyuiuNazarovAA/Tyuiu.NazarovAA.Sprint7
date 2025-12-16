namespace Tyuiu.NazarovAA.Sprint7.Project.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckRoutesFileExist()
        {
            string path = @"C:\Users\epiccipe\source\repos\Tyuiu.NazarovAA.Sprint7\Databases\Routes\Routes.csv";

            Assert.IsTrue(File.Exists(path));
        }

    }
}
