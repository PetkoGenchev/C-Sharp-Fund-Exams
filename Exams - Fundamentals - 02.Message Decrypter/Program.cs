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

            int n = int.Parse(Console.ReadLine());
            string code = @"^([$%])([A-Z][a-z]{2,})(\1): \[([0-9]+)\]\|\[([0-9]+)\]\|\[([0-9]+)\]\|$";
            Regex regex = new Regex(code);


            for (int i = 0; i < n; i++)
            {
                string entry = Console.ReadLine();

                Match match = regex.Match(entry);

                if (!match.Success)
                {
                    Console.WriteLine("Valid message not found!");
                }
                else
                {
                    StringBuilder stringBuilder = new StringBuilder();

                    stringBuilder.Append(char.ConvertFromUtf32(int.Parse(match.Groups[4].Value)));
                    stringBuilder.Append(char.ConvertFromUtf32(int.Parse(match.Groups[5].Value)));
                    stringBuilder.Append(char.ConvertFromUtf32(int.Parse(match.Groups[6].Value)));

                    Console.WriteLine($"{match.Groups[2].Value}: {stringBuilder.ToString()}");
                }
            }



        }
    }
}
