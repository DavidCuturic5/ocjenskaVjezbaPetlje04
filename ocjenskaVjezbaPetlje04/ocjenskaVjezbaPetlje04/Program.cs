﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezbaPetlje04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite pozitivan broj: ");
            int broj = int.Parse(Console.ReadLine());

            for (int i = 1; i < broj; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
