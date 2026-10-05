using System;

namespace PathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\dev\myfolder\file1.txt";

            Console.WriteLine("Path.DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("Path.PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}