using System;
using System.IO;

namespace FileFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // File class methods

            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"c:\temp\myfile.jpg", true);
            File.Delete(path);
            if (File.Exists(path)) {
                Console.WriteLine("File Exists.");
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"f:\new\myFile.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine("File Exists.");
            }
           
        }
    }
}
