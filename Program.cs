using System;
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

            Console.WriteLine("String-1: withoutX2");
            Console.WriteLine(withoutX2("xHi"));
            Console.WriteLine(withoutX2("Hxi"));
            Console.WriteLine(withoutX2("Hi"));
            Console.ReadLine();

            Console.WriteLine("Array-1: frontPieceX2");
            foreach (int[] a in new int[][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 1 } })
            {
                foreach (int i in frontPiece(a))
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
                Console.WriteLine();
            }
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

        static String withoutX2(String s)
        {
            StringBuilder sb = new StringBuilder(s, s.Length);

            if (s[1] == 'x')
            {
                sb.Remove(1, 1);
            }
            if (s[0] == 'x')
            {
                sb.Remove(0, 1);
            }
            return sb.ToString();
        }

        static int[] frontPiece(int[] a)
        {
            if (a.Length < 3)
            {
                return a;
            } 
            else
            {
                int[] tmp = new int[2];
                tmp[0] = a[0];
                tmp[1] = a[1];
                return tmp;
            }
        }
    }
}
