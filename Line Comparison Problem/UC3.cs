using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison_Problem
{
    internal class UC3
    {
        public static void CompareLine()
        {
            Console.WriteLine("Enter x1 and y1 coordinates: ");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2 coordinates: ");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            double ans1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Ans is :" + ans1);

            Console.WriteLine("Enter x3 and y3 coordinates: ");
            var x3 = Convert.ToDouble(Console.ReadLine());
            var y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x4 and y4 coordinates: ");
            var x4 = Convert.ToDouble(Console.ReadLine());
            var y4 = Convert.ToDouble(Console.ReadLine());
            double ans2 = Math.Sqrt(Math.Pow((x3 - x4), 2) + Math.Pow((y3 - y4), 2));
            Console.WriteLine("Ans is :" + ans2);

            if (ans1 >= ans2)
            {
                Console.WriteLine("ans1 line is greater than or equal to ans2 line");
            }
            else
            {
                Console.WriteLine("ans1 line is less than ans2 line");
            }
        }
}
