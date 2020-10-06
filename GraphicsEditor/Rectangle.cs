using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Rectangle : Base
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Draw()
        {
            
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for (int i = X; i <= secondX; i++)
            {
                Console.Write(Symbol);
            }
            for (int l = 1; l < secondY - Y; l++)
            {
                Console.SetCursorPosition(X, Y + l);
                Console.Write(Symbol);
                Console.SetCursorPosition(secondX, Y + l);
                Console.Write(Symbol);
            }
            Console.SetCursorPosition(X, secondY);
            for (int i = X; i <= secondX; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
        }
    }
}
