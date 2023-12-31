using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            rectangle rectangle1 = new rectangle(8, 4.5);

            Console.Write("\t Please Enter the length of the second rectangle:   ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("\t Please Enter the width of the second rectangle:   ");
            double width = double.Parse(Console.ReadLine());
            rectangle rectangle2 = new rectangle(length, width);
            Console.WriteLine("\n length:  {0}\n width:  {1}\n findarea:  {2}\n findperimeter:  {3}",
                rectangle1.getlength(), rectangle1.getwidth(), rectangle1.findarea(), rectangle1.findperimeter());
            Console.WriteLine();
            Console.WriteLine("\n length:  {0}\n width:  {1}\n findarea:  {2}\n findperimeter:  {3}",
                rectangle2.getlength(), rectangle2.getwidth(), rectangle2.findarea(), rectangle2.findperimeter());

            Console.ReadKey();
        }
    }
}
