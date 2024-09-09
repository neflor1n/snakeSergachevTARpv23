using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakeSergachevTARpv23
{
    public class mainClass
    {
        static void Main(string[] args)
        {

            Console.SetWindowSize(80, 25);

            // Raami joonistamine
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1 );

            foreach (var f figures)
            {
                f.Draw();
            }
            
            // Klassi esimene eksemplar
            Point p = new Point(4, 5, '*');
          

            Snake snake = new Snake(p,4, Direction.RIGHT);
            snake.Drow();
            snake.Move();

            // Loome toidu suvalises kohas vahemikus *80, 25* $-märgiga
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();



            static void Draw(Figure figure) { 
                figure.Drow();
            }
            

            // Lõputu silmus, milles kasutaja klõpsab nooltel ja madu liigub ja kui madu puudutab toitu, siis tekib toitu juurde ja joonistatakse pea
            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                // viivitage 100 millisekundit
                Thread.Sleep(100);
                // Nupuvajutuste kontrollimine
                if (Console.KeyAvailable)
                {
                    // Kontrollime, millist nuppu kasutaja vajutas ja liigutame madu selles suunas
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                    
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }
       
    }
}
