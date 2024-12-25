using System.Text;
using System.Text.Encodings.Web;

namespace Tyuiu.StoyakinNM.Sprint7.Project.V8.Lib
{
    public class DataService
    {
        public List<string[]> LoadDataFromFile(string path)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            string[] lines = File.ReadAllLines(path, Encoding.GetEncoding("windows-1251"));
            List<string[]> strings = new List<string[]>();

            foreach (string line in lines)
            {
                strings.Add(line.Split(';').Select(s => s.Trim()).ToArray());
            }

            foreach (var row in strings)
            {
                Console.WriteLine(string.Join(", ", row));
            }

            return strings;
        }
    }
}
