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
            string path = @"C:\Users\Kyle Pinkham\hello-world";
            string fileName = "text2.txt";
            string textToAdd = "Nice butts";
            int x = 3;
           

            using (StreamWriter writer = File.CreateText(path+fileName))
            {
                writer.Write(textToAdd+" "+x);
            }



            Console.ReadLine();
        }
    }
}
