using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Square : Base
    {
        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for (int i = X; i < secondX; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
            for (int l = 1; l < secondY - Y - 1; l++)
            {
                Console.SetCursorPosition(X, Y + l);
                Console.Write(Symbol);
                Console.SetCursorPosition(secondX - 1, Y + l);
                Console.Write(Symbol);
            }
            Console.SetCursorPosition(X, secondY - 1);
            for (int i = X; i < secondX; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
        }
    }
}
