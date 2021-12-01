using System;
using System.Collections.Generic;

namespace Day1Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>();
            
            string text = System.IO.File.ReadAllText("C:\\Users\\GWU\\source\\repos\\AdventOfCode2020\\Day1Part1\\Day1Part1\\input.txt");

            string[] stringInput = text.Split('\n');
            foreach(string item in stringInput)
            {
                input.Add(Convert.ToInt32(item));
            }
            // Part one
            //for(int i = 0; i < input.Count-1; i++)
            //{
            //    for (int j = 0; j < input.Count-1; j++)
            //    {
            //        if (j == i)
            //        {
            //            continue;
            //        }
            //        else if (2020 == input[i] + input[j])
            //        {
            //            Console.WriteLine(input[i] + " + " + input[j] + " = 2020 ");
            //            Console.WriteLine(input[i] * input[j] + " är svaret");
            //            break;
            //        }
            //    }
            //}
            // Part two
            for (int i = 0; i < input.Count - 1; i++)
            {
                for (int j = 0; j < input.Count - 1; j++)
                {
                    for (int k = 0; k < input.Count-1; k++)
                    if (k == i || k == j || j == i )
                    {
                        continue;
                    }
                    else if (2020 == input[i] + input[j] + input[k])
                    {
                        Console.WriteLine(input[i] + " + " + input[j] + " + "+ input[k] + " = 2020 ");
                        Console.WriteLine(input[i] * input[j] * input[k] + " är svaret");
                        break;
                    }
                }
            }
        }
    }
}
