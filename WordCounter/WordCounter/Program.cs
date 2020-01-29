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
        static int CountWords(String str)
        {
            bool state = false;
            int wordCounter = 0;
            foreach (int i in str)
            {
                if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
                {
                    state = false;
                }
                else if (state == false)
                {
                    state = true;
                    wordCounter++;
                }
            }
            return wordCounter;
        }

        static void Main(string[] args)
        {
            //1)first approach(aici ceva nu miroase a bine)
            //string filePath = @"e:\git\BasicPrograming\WordCounter\WordCounter\bin\Debug\test.txt";
            //string readedText = File.ReadAllText(filePath);
            //string[] splitedText = readedText.Split(' ');
            //Console.WriteLine("The number of words:" + splitedText.Length);

            //2)second approach
            string path = @"e:\git\BasicPrograming\WordCounter\WordCounter\bin\Debug\test.txt";
            string readText = File.ReadAllText(path);
            string[] splitedText = readText.Split(' ');
            Console.WriteLine("No of words:" + CountWords(readText));
            
        }
    }
}
