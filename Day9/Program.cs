using System;
using System.Collections.Generic;
using System.Linq;

namespace Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringList = System.IO.File.ReadAllLines("Day9.txt").ToList();
            var numberList = stringList.Select(s => Convert.ToInt64(s)).ToList();
            Console.WriteLine(encryptDisc(numberList));
        }
        static public long encryptDisc(List<long> numbersList)
        {
            var fail = true;
            for (var i = 25; i < numbersList.Count; i++)
            {   
                fail = true;
                for (var j = i - 25; j < i - 1; j++)
                {
                    for (var k = i - 24; k < i; k++)
                    {
                        if (numbersList[k] + numbersList[j] == numbersList[i])
                        {
                            fail = false;
                            break;
                        }
                    }
                    if (!fail) break;
                }
                if (fail) return numbersList[i];
            }
            return -1;
        }
    }
}
