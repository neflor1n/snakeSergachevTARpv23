using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeSergachevTARpv23
{

    //Lisa tulemus
    public class Score
    {
        private int currentScore;

        public Score()
        {
            currentScore = 0;
        }
        // Kui madu sööb toitu, suureneb skoor.
        public void Increment()
        {
            currentScore += 10;
        }
        // Ja kuvab see ekraanile 
        public void Display()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine($"Score: {currentScore}");
        }
    }
}
