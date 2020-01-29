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
            string path = @"e:\git\HW_Session8\ShoppingList1\ShoppingList1\bin\Debug\ShoppingList1.txt";

            string[] readedText =File.ReadAllLines(path);
            int allItems = 0;
            foreach (string element in readedText)
            {
                string splitedText = element.Substring(element.IndexOf('|') + 1);
                allItems += Convert.ToInt32(splitedText);

            }
            Console.WriteLine(allItems);

        }
    }
}
