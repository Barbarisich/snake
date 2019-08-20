using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;
        public Walls(int mapWidth, int mapHeight)
        {

            wallList = new List<Figure>();
            Console.SetBufferSize(mapWidth, mapHeight);

            HorisontalLine upline = new HorisontalLine(0, mapWidth - 2, 0, '+');
            HorisontalLine downline = new HorisontalLine(0, mapWidth - 2, mapHeight - 1, '+');
            VerticalLine leftline = new VerticalLine(0, 0, mapHeight - 1, '+');
            VerticalLine rightline = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '+');

            /*upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();*/

            wallList.Add(upline);
            wallList.Add(downline);
            wallList.Add(leftline);
            wallList.Add(rightline);

        }
        
        

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        { foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
         }
    }
}
