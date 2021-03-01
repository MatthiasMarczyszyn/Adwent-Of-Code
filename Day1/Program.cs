using System;

namespace Day1
{
    class Program
    {
          static void Main(string[] args)
        {
            string[] expenseReport = System.IO.File.ReadAllLines("Day1.txt");
            Console.WriteLine(ChacingTheSum(expenseReport));
        }

        public static int ChacingTheSum(string[] expenseReport)
        {
            foreach (var line in expenseReport)
            {
                for (var i = Array.IndexOf(expenseReport, line) + 1; i < expenseReport.Length - 1; i++)
                {
                    for (var j = i + 1; j < expenseReport.Length; j++)
                    {
                        if (Int32.Parse(line) + Int32.Parse(expenseReport[i]) + Int32.Parse(expenseReport[j]) == 2020) return Int32.Parse(line) * Int32.Parse(expenseReport[i]) * Int32.Parse(expenseReport[j]);
                    }
                }
            }
            return -1;
        }
    }
}
