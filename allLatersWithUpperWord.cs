using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;


// All first words in sentence starts with capital later separeted by comma.
namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(',').ToArray();
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;
            var output = cultInfo.ToTitleCase(string.Join(" ", input));
            Console.WriteLine(output);
        }

    }
}
