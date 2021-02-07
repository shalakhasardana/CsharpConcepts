using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace StringProcessor3
{
    // version : 3
    // problems in implementaton
    // Integrate 3rd party implementation.
    class Program
    {
        public static stringProgessorManager stringProcessorObject;
        public static void Main(string[] args)
        {
            string val;
            Console.Write("Enter the input: ");
            val = Console.ReadLine();
            int result = stringProcessorObject.GetSringProcessorSucceedeCounts(val);
            Console.WriteLine(result);

        }
    }
}
