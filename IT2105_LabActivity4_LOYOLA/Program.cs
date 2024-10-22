using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity4
{
    class Program
    {
        static string NumberComparison(int a, int b)
        {
            if (a < b)
            {
                return "FIRST";
            }
            else if (a > b)
            {
                return "SECOND";
            }
            else
            {
                return "ANY";
            }
        }
        static void Main(string[] args)
        {
            int t;

            do
            {
                Console.Write("No. of test cases: ");
                t = Convert.ToInt32(Console.ReadLine());
            } while (t < 1 || t > 10);
                

            List<string> results = new List<string>();

            for (int i = 0; i < t; i++)
            {
                int x, y;

                string[] inputs = Console.ReadLine().Split();
                x = Convert.ToInt32(inputs[0]);
                y = Convert.ToInt32(inputs[1]);

                if (x < 1 || x > 1000 || y < 1 || y > 1000)
                {
                    Console.WriteLine("Number inputted is invalid.");
                    break;
                }

                string result = NumberComparison(x, y);
                results.Add(result);
            }

            Console.WriteLine("Result:");
            foreach (string result in results)
            {
                Console.WriteLine(result);
            }
        Console.ReadKey();
        }
    }
}


