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
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            //FileStream s2 = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            

            Console.WriteLine(File.ReadAllText(path));

            File.AppendAllText(path, Console.ReadLine());

        }
    }
}
