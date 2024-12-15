using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_4
{
    internal class zad_4
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n=int.Parse(Console.ReadLine());
            var max = -10000000000000000;
            var min = 10000000000000000;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                    max = num;
                for (int c = 0; c < min; c++)
                { 
                if (num < min)
                    min = num;
                }
            }
            Console.WriteLine("min= " + min);
            Console.WriteLine("max= " + max);
            




        }
    }
}
