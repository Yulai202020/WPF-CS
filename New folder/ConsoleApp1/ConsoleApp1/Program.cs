using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[225];
            int i = 0;
            foreach (string pyth in Directory.EnumerateFiles("C:\\photos"))
            {
                FileInfo fileinfo = new FileInfo(pyth);
                    arr[i] = pyth;
                i++;
            }
            Console.WriteLine("\t|\t"+arr[0]+"\t|\t");
        }
    }
}
