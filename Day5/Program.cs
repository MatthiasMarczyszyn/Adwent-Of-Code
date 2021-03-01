using System;
using System.Collections.Generic;
using System.Linq;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> boardCards = System.IO.File.ReadAllLines("Day5.txt").ToList();
            List<int> idList = new List<int>();
            foreach (var line in boardCards)
            {
                idList.Add(ChackingIdFunction(line, 128, 8));

            }

            for (var i = 0; i < 1032; i++)
            {
                if (!idList.Contains(i) && idList.Contains(i + 1) && idList.Contains(i - 1))
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }

        static public int ChackingIdFunction(string codeString, int maxSizeRow, int maxSizeColumn)
        {
            var rowMin = 0; var rowMax = maxSizeRow - 1; var columnMin = 0; var columnMax = maxSizeColumn - 1;

            foreach (var codeLetter in codeString)
            {
                switch (codeLetter)
                {
                    case 'F':
                        rowMax = (rowMax + rowMin) / 2;
                        break;
                    case 'B':
                        rowMin = (rowMax + rowMin) / 2 + 1;
                        break;
                    case 'L':
                        columnMax = (columnMax + columnMin) / 2;
                        break;
                    case 'R':
                        columnMin = (columnMax + columnMin) / 2 + 1;
                        break;
                }
            }
            return rowMax * 8 + columnMax;
        }


    }
}
