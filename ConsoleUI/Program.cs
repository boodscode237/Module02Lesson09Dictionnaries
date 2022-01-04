using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> importantYears = new Dictionary<int, string>();

            importantYears[1492] = "Columbus discovered the new world.";
            importantYears[1969] = "Men walks on the moon.";
            importantYears[1999] = "Something happened";
            importantYears[2019] = "Corona virus";
            importantYears[2021] = "Variant Omicron";

            Console.WriteLine($"In the year 2019, this happened: {importantYears[2019]}");

            Console.ReadLine();
        }
    }
}
