using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square();
            Rectangle rectangle = new Rectangle();
            Triangle triangle = new Triangle();
            /*
            square.Color = ConsoleColor.Red;
            square.X = 2;
            square.Y = 2;
            square.Symbol = '*';
            square.Length = 5;
            square.Draw();
            
            rectangle.Color = ConsoleColor.Cyan;
            rectangle.X = 2;
            rectangle.Y = 2;
            rectangle.Width = 4;
            rectangle.Length = 6;
            rectangle.Symbol = '#';
            rectangle.Draw();
            */
            triangle.Color = ConsoleColor.Yellow;
            triangle.X = 4;
            triangle.Y = 16;
            triangle.Symbol = '!';
            triangle.Length = 10;
            triangle.Draw();

            Console.SetCursorPosition(0, 30);
        }
    }
}
