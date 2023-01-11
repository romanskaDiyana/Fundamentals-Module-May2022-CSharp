using System;

namespace _03ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //03. Extract File
            //Create a program that reads the path to a file and subtracts the file name and its extension.

            var pathFile = Console.ReadLine().Split('\\');

            var splitLastelement = pathFile[pathFile.Length - 1].Split('.');

            string fileName = splitLastelement[0];  
            string fileExtension = splitLastelement[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

        }
    }
}
