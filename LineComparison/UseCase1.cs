using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UseCase1
    {
        public static void Line()
        {
            int x1, y1, x2, y2;
            //user input
            Console.Write("Enter the first Co-ordinate in x-plane\n");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the first Co-ordinate in y-plane\n");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second co-ordinate in x-plane\n");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second co-ordinate in y-plane\n");
            y2 = Convert.ToInt32(Console.ReadLine());
            //Calculation: Length of line
            Console.Write("\nLine co-ordinates are:" +"(" +x1 +"," +y1 +")" +"," +"("+x2+","+y2 +")");
            double LineLength = Math.Sqrt((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            Console.Write("The length of the line is" + LineLength);
        }
    }
}
