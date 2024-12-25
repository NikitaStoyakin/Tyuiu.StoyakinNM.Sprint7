using Tyuiu.StoyakinNM.Sprint7.Project.V8.Lib;
namespace Tyuiu.StoyakinNM.Sprint7.Project.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FileLoadedTest()
        {
            var ds = new DataService();
            string path = @"C:\DataSprint7\Test.csv";
            List<string[]> wait = new List<string[]>();
            wait.Add(new string[] { "52", "А228КА", "Lamborgini", "Отличное", "В гараже", "100", "50", "80" });
            wait.Add(new string[] { "78", "67БИА9", "LADA", "Требуется ТО", "Владивосток", "60", "60", "50" });
            CollectionAssert.AreEqual(wait, ds.LoadDataFromFile(path));
        }
    }
}