﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3
{
    internal class zad_3
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i<=n; i++)
            {
                if (!(i % 4 == 0 && i % 8 == 0))
                {
                    Console.WriteLine(i);
                }

            }


        }
    }
}
