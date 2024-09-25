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
        private int gameDuration;
        public Score()
        {
            currentScore = 0;
            gameDuration = 0;
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
        public void SetDuration(int duration)
        {
            gameDuration = duration;
        }
        public void SaveScore()
        {
            string path = "game_scores.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine($"Score: {currentScore}, Duration: {gameDuration} seconds, Date: {DateTime.Now}");
            }
        }
        public int CurrentScore
        {
            get { return currentScore; }
        }
    }
}
