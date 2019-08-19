using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {


            /* Point p1 = new Point(1, 3, '*');
             p1.Draw();

             Point p2 = new Point(4, 5, '#');
             p2.Draw();

             Console.ReadLine();*/

            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);

            Point p1 = new Point(1, 3, '*');
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + "; p1.y = " + p1.y);

            Point p2 = new Point(4, 5, '#');
            Reset(p2);
            Console.WriteLine("Call Move. p2.x = " + p2.x + "; p2.y = " + p2.y);

            Console.ReadLine();

        }

        static void Func1(int value)
        {
          //x = x + 1;

        }

        static void Func2(int value)
        {
           value = value + 1;
        }

        static void Func3(int x)
        {
            x = x + 1;
        }

        static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;

        }

        static void Reset(Point p)
        {
            p = new Point();
        }

    }
}
