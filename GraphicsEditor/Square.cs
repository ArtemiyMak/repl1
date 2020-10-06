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
            Console.SetCursorPosition(X, Y+1);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            for (int l = 2; l < Length + 1; l++)
            {
                Console.SetCursorPosition(X, l + 1);
                Console.Write(Symbol);
                Console.SetCursorPosition(Length + 1, l + 1);
                Console.Write(Symbol);

            }
            Console.SetCursorPosition(X, Length + 2);
            for (int i = 0; i < Length; i++)
            {
                Console.Write(Symbol);
            }
            Console.WriteLine();
        }
    }
}
