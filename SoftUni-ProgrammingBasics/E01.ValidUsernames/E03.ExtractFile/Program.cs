using System;

namespace E03.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            string fileName = sentence.Substring(sentence.LastIndexOf("\\") + 1);

            int dotIndex = fileName.LastIndexOf('.');
            string extention = fileName.Substring(dotIndex + 1); 
            fileName = fileName.Substring(0, dotIndex);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
