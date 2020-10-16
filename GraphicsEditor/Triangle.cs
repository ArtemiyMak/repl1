using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Triangle : Base
    {
        public void Draw()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            for (int i = 1; i < (Length / 2) + (Length % 2); i++)
            {
                Console.SetCursorPosition(X + i, Y - i);
                Console.Write(Symbol);
                Console.SetCursorPosition(X + Length - i - 1, Y - i);
                Console.Write(Symbol);
            }
        }
    }
}
