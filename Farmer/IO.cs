using System.IO;

namespace Farmer
{
    class IO
    {
        public static void WriteToFile(string content)
        {
            Config.sw.WriteLine(content);
        }
    }
}
