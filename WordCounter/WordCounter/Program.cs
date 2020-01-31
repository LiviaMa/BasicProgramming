using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string filePath = @"e:\git\BasicProgramming\WordCounter\WordCounter\bin\Debug\test.txt";
            int numberOfWords = 0;
            string[] readedText = File.ReadAllLines(filePath);
            foreach (string line in readedText)
            {
                string[] wordsPerLine = line.Split(' ');
                numberOfWords += wordsPerLine.Length;
            }
            Console.WriteLine("Number of words is:" + numberOfWords + Environment.NewLine);
        }
    }
}
