using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashna_16._12
{
    internal class zad_1
    {
        static void Main(string[] args)
        {
            for (int i=10; i<=25; i++)
            { 
                if(i%2 == 0)
                {
                    Console.WriteLine($"   {i}");
                }
                else
                    Console.WriteLine($"{i}");
            }



        }
    }
}
