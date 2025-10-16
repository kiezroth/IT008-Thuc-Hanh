using System.Text;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            cFile cFile = new cFile();
            cFile.readInput();
            cFile.directoryShow();
        }
    }
}
