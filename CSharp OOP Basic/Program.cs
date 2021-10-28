using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLines;


namespace CSharp_OOP_Basic { 
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 6;
            point.Y = 8;

            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);

            point = new Point(8, 10);
            Console.WriteLine(point.X);
            Console.WriteLine(point.Y);
        }
    }
}

