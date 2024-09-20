using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT2105_Seatwork1_LOYOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            int eng, math, sci, mapeh;
            double sum, avg, engdouble, mathdouble, scidouble, mapehdouble;

            Console.Write("Please input student's grade in English: ");
            string english = Console.ReadLine();

            Console.Write("Please input student's grade in Math: ");
            string mth = Console.ReadLine();

            Console.Write("Please input student's grade in Science: ");
            string science = Console.ReadLine();

            Console.Write("Please input student's grade in MAPEH: ");
            string mape = Console.ReadLine();

            eng = Convert.ToInt32(english);
            math = Convert.ToInt32(mth);
            sci = Convert.ToInt32(science);
            mapeh = Convert.ToInt32(mape);

            engdouble = Convert.ToDouble(eng);
            mathdouble = Convert.ToDouble(math);
            scidouble = Convert.ToDouble(sci);
            mapehdouble = Convert.ToDouble(mapeh);


            sum = engdouble + mathdouble + scidouble + mapehdouble;
            avg = sum / 4;

            Console.WriteLine("Average: " + avg);

            if(avg == 100 && avg >= 98)
            {
                Console.WriteLine("With Highest Honors");
            }
            else if(avg >= 95 && avg < 97.99)
            {
                Console.WriteLine("With High Honors");
            }
            else if (avg >= 90 && avg < 94.99)
            {
                Console.WriteLine("With Honors");
            }
            else if (avg >= 75 && avg < 89.99)
            {
                Console.WriteLine("Passed");
            }
            else if (avg < 75)
            {
                Console.WriteLine("Failed");
            }


            Console.ReadKey();
        }
    }
}
