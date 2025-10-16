using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class cFile
    {
        private string strPath { get; set; }
        private string[]? listFile { get; set; }
        private string[]? listFolder { get; set; }
        private bool isEmpty { get; set; }
        private bool isExist { get; set; }
        public cFile()
        {
            strPath = "";
            isEmpty = true;
            isExist = false;
            
        }

        public void directoryGetObj()
        {
            if (Directory.Exists(strPath))
            {
                listFile = Directory.GetFiles(strPath);
                listFolder = Directory.GetDirectories(strPath);
                if (listFile.Length != 0 || listFolder.Length != 0)
                    isEmpty = false;
                isExist = true;
            }
        }
        public bool readInput()
        {
            strPath = Console.ReadLine()!;
            directoryGetObj();
            return true;
        }
        private string getName(string filePath)
        {
            string name = "";
            int i = filePath.Length - 1;
            while (i >= 0 && filePath[i] != '\\')
            {
                name += filePath[i];
                i--;
            }
            char[] rev = name.ToCharArray();
            Array.Reverse(rev);
            return new string(rev);
        }
        public void directoryShow()
        {
            Console.OutputEncoding = Encoding.UTF8;
            if (this.isExist == false) { Console.WriteLine("Đường dẫn không tồn tại"); return; }
            if (this.isEmpty) { Console.WriteLine("Thư mục trống"); return; }

            const int padName = -70, padDate = -30;
            Console.WriteLine($"{"Name",padName} {"Date",padDate}\n");
            if (listFolder != null) 
                foreach (var folder in listFolder)
                    Console.WriteLine($"{getName(folder),padName} {Directory.GetLastWriteTime(folder),padDate}");

            if (listFile != null)
                foreach (var file in listFile!)
                    Console.WriteLine($"{getName(file),padName} {Directory.GetLastWriteTime(file),padDate}");
        }
    }
}
