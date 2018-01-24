using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;

namespace problem1
{
    class day2
    {
        static void Main(string[] args)
        {
            string[] whole = File.ReadAllLines("day2-data.csv");
            int sum = 0;
            int max = 0;
            Console.WriteLine(whole.Length);
            for (int i = 0; i < whole.Length; i++)
            {
                string line = whole[i];
                string[] vals = line.Split(',');
                


                for (int j = 0; j < vals.Length; j++)
                {
                    int v = int.Parse(vals[j]);
                    for (int k = 0; k < vals.Length; k++)
                    {
                        int div = int.Parse(vals[k]);
                        
                        if (v%div == 0 && k !=j && v !=div)
                        {
                            Console.WriteLine(v / div + " " + v + " " + div);
                            max = v/div;
                            //k = 10000;
                            //j = 10000;
                        }
                        
                    }
                    
                }
                sum = sum + max;


            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }

    }

