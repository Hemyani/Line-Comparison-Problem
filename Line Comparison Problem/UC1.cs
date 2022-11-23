using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    internal class UC1
    {
        public static void Comparison()
        {
            Console.WriteLine("Enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            var finalResult = Distance(x1, x2, y1, y2);
            Console.WriteLine("Distance Between coordinates {0},{1} and {2},{3} is {4:F}", x1, y1, x2, y2, finalResult);
        }
        private static double Distance(double x1, double y1, double x2, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            return result;
        }
    }
}
