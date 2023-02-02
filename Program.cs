﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CodingBat Exercies, one chosen at random from each section");
            Console.WriteLine();

            Console.WriteLine("Warmup-1: max1020");
            Console.WriteLine(max1020(11, 19));
            Console.ReadLine();

            Console.WriteLine("Warmup2: array667");
            Console.WriteLine(array667(new int[] { 6, 6, 2}));
            Console.WriteLine(array667(new int[] { 6, 6, 2, 6 }));
            Console.WriteLine(array667(new int[] { 6, 7, 2, 6 }));
            Console.ReadLine();


        }

        static int max1020(int a, int b)
        {
            int c = 0;
            int d = 0;
            if (a > b) { c = a; d = b; }
            else { c = b; d = a; }

            if ((10 <= c) && (c <= 20)) { return c; }
            else if ((10 <= d) && (d <= 30)) { return d; }
            else { return 0; }

        }

        static int array667(int[] a)
        {
            int count = 0;
            for (int i = 0; i < a.Length - 2; i++)
            {
                if ((a[i] == 6) && (a[i+1] == 6))
                {
                    count++;
                }
                else if ((a[i] == 6) && (a[i+1] == 7))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
