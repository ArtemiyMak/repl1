using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Base
    {
        public Base(ConsoleColor color, char symbol, int x, int y, int length)
        {
            Color = color;
            Symbol = symbol;
            X = x;
            Y = y;
            Length = length;
        }
        public ConsoleColor Color { get; set; }
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Length { get; set; }
    }
}
