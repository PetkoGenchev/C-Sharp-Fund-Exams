using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.ExceptionServices;
using System.Diagnostics.Tracing;

namespace PetkoSoftUniFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            string entry = Console.ReadLine();

            while (true)
            {
                string ch = Console.ReadLine();

                if (ch == "End")
                {
                    break;
                }

                List<string> change = ch
                    .Split()
                    .ToList();

                switch (change[0])
                {
                    case "Translate":
                        entry = entry.Replace(change[1], change[2]);
                        Console.WriteLine(entry);
                        break;
                    case "Includes":
                        bool doesIt = entry.Contains(change[1]);
                        Console.WriteLine(doesIt);
                        break;
                    case "Start":
                        bool doesIt2 = entry.StartsWith(change[1]);
                        Console.WriteLine(doesIt2);
                        break;
                    case "Lowercase":
                        entry = entry.ToLower();
                        Console.WriteLine(entry);
                        break;
                    case "FindIndex":
                        int index = entry.LastIndexOf(change[1]);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        entry = entry.Remove(int.Parse(change[1]), int.Parse(change[2]));
                        Console.WriteLine(entry);
                        break;
                    default:
                        Console.WriteLine("Contact Support");
                        break;
                }
            }

        }
    }
}
