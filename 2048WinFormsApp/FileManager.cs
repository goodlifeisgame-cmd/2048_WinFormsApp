using System.Text;

namespace _2048WinFormsApp
{
    public class FileManager
    {
        public static void Record(string path, string tex)
        {
            using (var sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                sw.WriteLine(tex);
            }
        }

        public static string GetData(string path)
        {
            return File.ReadAllText(path);
        }

        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

    }
}
