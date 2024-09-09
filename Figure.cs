using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeSergachevTARpv23
{
    public class Figure
    {
        // Punktide komplekt
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
