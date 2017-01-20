using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
   class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\\";
            string fileName = "text.txt";
            string textToAdd = "This is a test file for our purposes";

            string text2Add = (x);

            using (StreamWriter writer = File.CreateText(path+fileName))
            {
                writer.Write(textToAdd);
            }



            Console.ReadLine();
        }
    }
}
