using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak5
{
    public class Number
    {
       
            public int Min(int a, int b, int c)
            {
                int min = 0;
                if (a < b && a < c)
                    Console.WriteLine(" Min dari ketiga nilai adalah : {0}", min = a);
                else if (b < a && b < c)
                    Console.WriteLine(" Min dari ketiga nilai adalah : {0}", min = b);
                else if (c < a && c < b)
                    Console.WriteLine(" Min dari ketiga nilai adalah : {0}", min = c);

                return min;
            }
            public int Max(int a, int b, int c)
            {
                int max = 0;
                if (a > b && a > c)
                    Console.WriteLine(" Max dari ketiga nilai adalah : {0}", max = a);
                else if (b > a && b > c)
                    Console.WriteLine(" Max dari ketiga nilai adalah : {0}", max = b);
                else if (c > a && c > b)
                    Console.WriteLine(" Max dari ketiga nilai adalah : {0}", max = c);

                return max;
            }
        
    }
}

