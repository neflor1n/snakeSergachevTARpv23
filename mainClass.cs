using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace snakeSergachevTARpv23
{
    public class mainClass
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(105, 25);
            
            // Klassi esimene eksemplar

            Walls walls = new Walls(80, 25);
            walls.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p,4, Direction.RIGHT);
            snake.Draw();
            

            // Loome toidu suvalises kohas vahemikus *80, 25* $-märgiga
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();


            Score score = new Score();
            score.Display();


            DateTime startTime = DateTime.Now;
            bool gameOver = false;

            // Peamine mängutsükkel
            while (!gameOver)
            {
                // Arvutage kulunud aeg
                TimeSpan elapsedTime = DateTime.Now - startTime;

                // Kontrollige kokkupõrkeid
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    score.SetDuration((int)elapsedTime.TotalSeconds);
                    score.SaveScore();
                    gameOver = true;
                }

                // Kontrollige, kas madu sööb toitu
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    score.Increment();
                    score.Display();
                }
                else
                {
                    snake.Move();
                }

                // Kuva kulunud aeg paremas ülanurgas
                Console.SetCursorPosition(80, 0); // Määrake asukoht paremas ülanurgas
                Console.WriteLine($"Elapsed Time: {elapsedTime.Seconds + elapsedTime.Minutes * 60} seconds");

                // Liikumiskiiruse viivitus
                Thread.Sleep(100);

                // Käsitsege kasutaja sisendit
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            // Lõpliku skoori kuva
            Console.Clear();
            Console.WriteLine($"Game Over! Your score: {score.CurrentScore}");
            Console.WriteLine($"Total Time: {(DateTime.Now - startTime).TotalSeconds} seconds");
        }

    }
}
