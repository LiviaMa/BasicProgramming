using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"e:\git\BasicProgramming\ShoppingList1\ShoppingList1\bin\Debug\ShoppingList1.txt";

            string[] readedText =File.ReadAllLines(path);
            int allItems = 0;
            foreach (string line in readedText)
            {
                string[] shoppingItems = line.Split('|');
                allItems += Convert.ToInt32(line.Split('|')[1]);
                Console.WriteLine(line);
            }
            Console.WriteLine(Environment.NewLine + "Number of all items is: " + allItems + Environment.NewLine);

        }
    }
}
