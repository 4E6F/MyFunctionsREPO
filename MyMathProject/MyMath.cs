using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathProject
{
    internal class MyMath
    {
        public static int Calc_ggT(int a, int b)
        {
            int z = 0;
            while (b != 0)
            {
                z = a % b;
                a = b;
                b = z;
            }
            return a;
        }

        public static int Calc_kgV(int a, int b)
        {
            return (a * b) / Calc_ggT(a, b);
        }

        public static int clac_rekursive_ggT(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }

            return clac_rekursive_ggT(b, a % b);
        }


        public static int calc_mean(int[] storage)
        {
            int sum = 0;
            int m = 0;
            foreach(int val in storage)
            {
                sum += val;
                m++;
            }

            return sum / m;
        }

        
        public static int calc_min(int[] storage)
        {
            int min = storage[0];
            int next = 0;
            foreach(int val in storage)
            {
                
            }
            
        }

    }
}
