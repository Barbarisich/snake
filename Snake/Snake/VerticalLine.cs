using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        
            List<Point> pList;


            public VerticalLine(int x, int yLow, int yHigh, char sym)
            {

                pList = new List<Point>();

                for (int y = yLow; y <= yHigh; y++)
                {


                    Point p = new Point(x, y, sym);
                    pList.Add(p);


                }

                /*Point p1 = new Point(4, 4, '*');
                Point p2 = new Point(5, 4, '*');
                Point p3 = new Point(6, 4, '*');

                pList.Add(p1);
                pList.Add(p2);
                pList.Add(p3);*/
            }

            public void Draw()
            {
                foreach (Point p in pList)
                {
                    p.Draw();
                }
            }



        }

    }
