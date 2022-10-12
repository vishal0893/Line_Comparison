using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UseCase3
    {
        public static void Linecompare2()
        {
            int x1, y1, x2, y2, a1, b1, a2, b2;
            //user input
            Console.Write("Enter the first Co-ordinate in x-plane for first line\n");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first Co-ordinate in y-plane for first line\n");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second co-ordinate in x-plane for first line\n");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second co-ordinate in y-plane for first line\n");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first Co-ordinate in x-plane for second line\n");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first Co-ordinate in y-plane for second line\n");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second co-ordinate in x-plane for second line\n");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second co-ordinate in y-plane for second line\n");
            b2 = Convert.ToInt32(Console.ReadLine());
            //Calculation: Length of line
            Console.Write("\nLine 1 co-ordinates are:" + "(" + x1 + "," + y1 + ")" + "," + "(" + x2 + "," + y2 + ")");
            Console.Write("\nLine 2 co-ordinates are:" + "(" + a1 + "," + b1 + ")" + "," + "(" + a2 + "," + b2 + ")");
            double LineLength1 = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Double LineLength2 = Math.Sqrt((Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2)));
            Console.Write("\nThe length of the line1 is" + LineLength1 + "\n");
            Console.Write("\nThe length of the line2 is" + LineLength2 + "\n");
            if (LineLength1 == LineLength2)
                Console.Write("\nThe given two lines are equal.");
            else if (LineLength2 > LineLength1)
                Console.Write("\nLine1 is smaller than line2.");
            else if (LineLength1 > LineLength2)
                Console.Write("\nLine1 is greater than line2.");
        }
    }
}