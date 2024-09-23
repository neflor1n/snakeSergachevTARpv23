using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeSergachevTARpv23
{
    public class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char sym;

        Random random = new Random();

        
        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            // Anname edasi väärtuse "mapWidth" ja nii edasi väärtuse
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
            
        }
        // Klassi tegemine, mis loob toitu juhuslikus kohas
        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
