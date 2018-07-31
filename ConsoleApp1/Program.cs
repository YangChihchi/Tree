using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i = 1;
            int k = 1;
            string j = "";


            for (k = 1; k <= 5; k++) // 層
            {
                for (i = 1; i <= 5 - k; i++) // 空格
                {
                    Console.Write(" ");
                }

                for (i = 1; i <= k * 2 - 1; i++) //*
                {
                    j += "*";
                }
                Console.WriteLine(j);
                j = "";
            }
        }*/

            int num_levels = 16; //層

            int num_blank;//空格
            int num_star;//*
            int num_new_line = 1;//換行

            num_blank = num_levels - 1;
            num_star = 1;

            int t = 1;
            while (t <= num_levels)
            {
                {
                    int i = 1;
                    while (i <= num_blank)
                    {
                        Console.Write(" ");
                        i += 1;
                    }
                }
                {
                    int i = 1;
                    while (i <= num_star)
                    {
                        Console.Write("*");
                        i += 1;
                    }
                }
                {
                    int i = 1;
                    while (i <= num_new_line)
                    {
                        Console.Write("\n");
                        i += 1;
                    }
                }


                num_blank -= 1;
                num_star += 2;
                t += 1;
            }

        }
    }
}
