/*
Leyland Numbers from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-04 

A Leyland number is a number which can be expressed as a^b + b^a where a and b are integers greater than 1. 
For Example: 
17= 2^3 + 3^2 
8= 2^2 +2^2 

Write a code to check if a given number is a Leyland number or not. 

Leyland numbers: 3, 8, 17, 32, 54, 57, 100, 145, 177, 320, 368, 512, 593, 945, 1124, 1649, 2169, 2530, 4240, 5392, 6250, 7073, 8361, 16580, 18785, 20412, 23401, 32993, 60049, 65792, 69632, 93312, 94932, 131361, 178478, 262468, 268705, 397585, 423393, 524649, 533169, ...
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeylandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = 8589935681; // Insert here a number to check if a given number is a Leyland number or not.
            long n = 0;
            bool b = false;

            for (int i = 2; i < 100; i++)
            {
                for(int j = 2; j < 100; j++)
                {
                    n = (long)Math.Pow(i, j) + (long)Math.Pow(j, i);
                    b = (n == number);
                    

if (b == true) Console.WriteLine($"{i}^{j}+{j}^{i} = {n.ToString()}");

                    if (n > number && j == 2 || b == true) goto Out;
                    
                    if (n > number) break;
                }
            }

            Out:
            Console.WriteLine($"The number {number} {((b == true) ?"is":"is not")} a Leyland number.");
        }
    }
}