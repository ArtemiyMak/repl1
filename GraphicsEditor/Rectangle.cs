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
        public void Draw()
        {   
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y + 1);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            for (int l = 0; l < Height - 1; l++)
            {
                Console.SetCursorPosition(X, Y + l + 1);
                Console.Write(Symbol);
                Console.SetCursorPosition(Length + 1, Y + l + 1);
                Console.Write(Symbol);
            }
            Console.SetCursorPosition(X, Height + 2);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
        }
    }
}
