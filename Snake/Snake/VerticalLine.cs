﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        
            public VerticalLine(int x, int yHigh, int yLow, char sym)
            {

                pList = new List<Point>();

                for (int y = yHigh; y <= yLow; y++)
                {


                    Point p = new Point(x, y, sym);
                    pList.Add(p);


                }

            }

    }

}
