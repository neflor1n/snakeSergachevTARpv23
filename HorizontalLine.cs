using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeSergachevTARpv23
{
    // "Figuur" klassi järglane
    public class HorizontalLine : Figure
    {
        

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        { 
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
            
        }
        
        public virtual void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            base.Draw();
            
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}
