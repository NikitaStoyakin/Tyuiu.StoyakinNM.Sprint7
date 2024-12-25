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
            string path = @"C:\\DataSprint7\\Test.csv";
            List<string[]> actual = ds.LoadDataFromFile(path);

            List<string[]> wait = new List<string[]>();
            wait.Add(new string[] { "52", "А228КА", "Lamborgini", "Отличное", "В гараже", "100", "50", "80" });
            wait.Add(new string[] { "78", "67ВИЛ9", "LADA", "Нужно ТО", "Владивосток", "60", "60", "50" });

            for (int i = 0; i < wait.Count; i++)
            {
                Console.WriteLine($"Checking row {i}:");
                for (int j = 0; j < wait[i].Length; j++)
                {
                    Console.WriteLine($"Expected: {wait[i][j]}, Actual: {actual[i][j]}");
                    Assert.AreEqual(wait[i][j], actual[i][j], $"Mismatch at row {i}, column {j}");
                }
            }
        }
    }
}