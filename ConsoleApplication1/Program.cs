using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Schüler\Documents\MyTextFile.txt";


            if (!(File.Exists(path)))
            {
                StreamWriter sw = File.CreateText(path);
                
                sw.WriteLine("Hello");
                sw.WriteLine("and");
                sw.WriteLine("Welcome");
                sw.Close();
                
            }


            Console.WriteLine(File.ReadAllText(path));

            File.AppendAllText(path, Console.ReadLine() + "\n");

        }
    }
}
