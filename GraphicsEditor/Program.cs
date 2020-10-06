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
            
            square.Color = ConsoleColor.Red;
            square.X = 2;
            square.Y = 2;
            square.secondX = 6;
            square.secondY = 6;
            square.Symbol = '*';
            square.Length = 5;
            square.Draw();
            
            Rectangle rectangle = new Rectangle();
            /*
            rectangle.Color = ConsoleColor.Cyan;
            rectangle.X = 4;
            rectangle.Y = 4;
            rectangle.secondX = 18;
            rectangle.secondY = 8;
            rectangle.Symbol = '№';
            rectangle.Draw();
            */
            Console.SetCursorPosition(0, 30);
        }
    }
}
