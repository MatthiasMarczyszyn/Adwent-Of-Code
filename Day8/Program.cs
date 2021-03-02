using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> loopOrders = System.IO.File.ReadAllLines("Day8.txt").ToList();
            Console.WriteLine(accValue(loopOrders));
        }

        static public int accValue(List<string> loopOrders)
        {
            var acc = 0;
            var orderName = "NONE";
            var step = 0;
            var index = 0;
            var stepList = new List<int>();
            while (!stepList.Contains(index))
            {   
                stepList.Add(index);
                var line = loopOrders[index];
                loopOrders[index].Split('+', ' ', StringSplitOptions.RemoveEmptyEntries);
                orderName = line.Substring(0, 3);
                step = Int32.Parse(line.Substring(3, line.Length-3));
                switch (orderName)
                {
                    case "nop":
                        index++;
                        break;
                    case "jmp":
                        index += step;
                        break;
                    case "acc":
                        acc += step;
                        index++;
                        break;
                }

            }
            return acc;
        }

        
    }
}