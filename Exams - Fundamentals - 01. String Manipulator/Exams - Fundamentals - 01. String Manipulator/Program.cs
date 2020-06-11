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
                        entry.Replace(change[1], change[2]);
                        Console.WriteLine(entry);
                        break;
                    case "Includes":
                        Console.WriteLine(entry.Contains(change[1]));
                        break;
                    case "Start":
                        Console.WriteLine(entry.StartsWith(change[1]));
                        break;
                    case "Lowercase":
                        Console.WriteLine(entry.ToLower());
                        break;
                    case "FindIndex":
                        int index = entry.LastIndexOf(change[1]);
                        Console.WriteLine(index);
                        break;
                    case "Remove":
                        entry.Remove(int.Parse(change[1]), int.Parse(change[2]));
                        break;
                    default:
                        Console.WriteLine("Contact Support");
                        break;
                }
            }

        }
    }
}
