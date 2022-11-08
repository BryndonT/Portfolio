// Grading ID: S1908
// Lab 6
// Due Date: 03/21/2021
// Course Section: CIS 199-02
// This program displays four different right angle triangles which form a pattern.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 10; // Assigns max level of characters per line.

            for (int row = 1; row <= MAX; ++row) // These lines create Pattern A triangle.
            {
                for (int star = 1; star <= row; ++star)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int row = MAX; row >= 1; --row) // These lines create pattern B triangle.
            {
                for (int star = 1; star <= row; ++star)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int row = MAX; row >= 1; --row) // These lines create pattern C triangle while using algebra to get correct values.
            {
                for (int space = 1; space <= MAX - row; ++space)
                    Console.Write(" ");
                for (int star = 1; star <= row; ++star)
                    Console.Write("*");
                Console.WriteLine();
            }

            for (int row = 1; row <= MAX; ++row) // These lines create pattern D triangle while using algebra to get correct values.
            {
                for (int space = 1; space <= MAX - row; ++space) 
                    Console.Write(" ");
                for (int star = 1; star <= row; ++star)
                    Console.Write("*");
                Console.WriteLine();
            }


        }
    }
}
