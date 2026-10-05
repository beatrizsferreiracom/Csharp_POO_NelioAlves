using System;

namespace FileFileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\dev\file1.txt";
            string targetPath = @"C:\dev\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}