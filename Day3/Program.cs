using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(treeCounter(System.IO.File.ReadAllLines("Day3.txt")));
        }

        static public int treeCounter(string[] road)
        {
            var trees = 0;
            int right = 0, down = 0;
            while (down < road.Length)
            {
                if (road[down][right % road[down].Length] == '#') trees++;
                down ++;
                right += 3;
            }
            return trees;
        }
    }
}
