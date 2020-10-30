using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Rectangle : Square
    {
        public int Height { get; set; }
        public Rectangle(ConsoleColor color, char symbol, int x, int y, int length, int heigth) : base(color, symbol, x, y, length)
        {
            
        }
        public void Draw()
        {   
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            for (int l = 2; l < Height; l++)
            {
                Console.SetCursorPosition(X, Y + l - 1);
                Console.Write(Symbol);
                Console.SetCursorPosition(X + Length - 1, Y + l - 1);
                Console.Write(Symbol);
            }
            Console.SetCursorPosition(X, Y + Height - 1);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
        }
    }
}
