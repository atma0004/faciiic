using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faciiic
    {
    class Program
        {
        static void Main(string[] args)
            {
            int f = 1;
            int l = 2;
            int k = 0;
            while (f<4000000 && l <4000000)
                {
                if (f%2==0)
                    {
                    k=k+f;
                    }
                f=f+l;
                if (l%2==0)
                    {
                    k=k+l;
                    }
                l=f+l;
                }

            Console.WriteLine(k);
            Console.ReadLine();
            }
        }
    }
