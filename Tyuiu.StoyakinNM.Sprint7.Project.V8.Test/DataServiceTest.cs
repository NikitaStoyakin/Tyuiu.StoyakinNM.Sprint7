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
            wait.Add(new string[] { "52", "�228��", "Lamborgini", "��������", "� ������", "100", "50", "80" });
            wait.Add(new string[] { "78", "67���9", "LADA", "��������� ��", "�����������", "60", "60", "50" });
            CollectionAssert.AreEqual(wait, ds.LoadDataFromFile(path));
        }
    }
}