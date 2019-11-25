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

            // FileInfo

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"f:\new\myFile.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                Console.WriteLine("File Exists.");
            }

            // Directory

            Directory.CreateDirectory(@"c:\all");
            var files =  Directory.GetFiles(@"c:\projects\CSharp", ".", SearchOption.AllDirectories);

            foreach (var file in files)
                Console.WriteLine(file);

           
        }
    }
}
