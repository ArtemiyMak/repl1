using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditor
{
    class Input
    {
        public void InputFigure()
        {
            bool in_cycle = true;

            while (in_cycle)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Введите: 1 - нарисовать фигуру, 2 - очистить экран, 3 - выйти: ");
                string input = Console.ReadLine();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("                                                                                           ");
                Console.SetCursorPosition(0, 0);
                switch (input)
                {
                    case "1":
                        {
                            
                            Console.Write("Введите: 1 - нарисовать квадрат, 2 - нарисовать прямоугольник, 3 - нарисовать треугольник: ");
                            string inputFig = Console.ReadLine();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("                                                                                                                                 ");
                            Console.SetCursorPosition(0, 0);
                            switch (inputFig)
                            {
                                case "1":
                                    {
                                        Console.Write("Введите X левого верхнего угла квадрата: ");
                                        int.TryParse(Console.ReadLine(), out int squareX);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (squareX < 0)
                                        {
                                            squareX = 0;
                                        }

                                        Console.Write("Введите Y левого верхнего угла квадрата: ");
                                        int.TryParse(Console.ReadLine(), out int squareY);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (squareY < 0)
                                        {
                                            squareY = 0;
                                        }

                                        Console.Write("Введите длину квадрата: ");
                                        int.TryParse(Console.ReadLine(), out int squareLenght);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (squareLenght < 0)
                                        {
                                            squareLenght = 4;
                                        }

                                        Console.Write("Введите символ, которым будет выведен квадрат: ");
                                        char.TryParse(Console.ReadLine(), out char squareSymbol);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (squareSymbol == ' ')
                                        {
                                            squareSymbol = '*';
                                        }

                                        Console.WriteLine("Введите номер цвет квадрата");
                                        Console.WriteLine("Black(0), DarkBlue(1), DarkGreen(2), DarkCyan(3), DarkRed(4), DarkMagenta(5), DarkYellow(6), Gray(7)");
                                        Console.Write("DarkGray(8), Blue(9), Green(10), Cyan(11), Red(12), Magenta(13), Yellow(14), White(15): ");
                                        int.TryParse(Console.ReadLine(), out int squareColor);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.WriteLine("                                                                                                                        ");
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (squareColor < 0 || squareColor > 15)
                                        {
                                            squareColor = 15;
                                        }
                                        Square square = new Square((ConsoleColor)squareColor, squareSymbol, squareX, squareY, squareLenght);
                                        square.Draw();
                                        break;
                                    }
                                case "2":
                                    {
                                        
                                        Console.Write("Введите X левого верхнего угла прямоугольника: ");
                                        int.TryParse(Console.ReadLine(), out int rectangleX);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (rectangleX < 0)
                                        {
                                            rectangleX = 0;
                                        }

                                        Console.Write("Введите Y левого верхнего угла прямоугольника: ");
                                        int.TryParse(Console.ReadLine(), out int rectangleY);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (rectangleY < 0)
                                        {
                                            rectangleY = 0;
                                        }

                                        Console.Write("Введите длину прямоугольника: ");
                                        int.TryParse(Console.ReadLine(), out int rectangleLenght);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (rectangleX < 0)
                                        {
                                            rectangleX = 4;
                                        }

                                        Console.Write("Введите высоту прямоугольника: ");
                                        int.TryParse(Console.ReadLine(), out int rectangleHeight);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (rectangleX < 0)
                                        {
                                            rectangleX = 4;
                                        }

                                        Console.Write("Введите символ, которым будет выведен квадрат: ");
                                        char.TryParse(Console.ReadLine(), out char rectangleSymbol);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);

                                        Console.WriteLine("Введите цвет квадрата");
                                        Console.WriteLine("Black(0), DarkBlue(1), DarkGreen(2), DarkCyan(3), DarkRed(4), DarkMagenta(5), DarkYellow(6), Gray(7)");
                                        Console.Write("DarkGray(8), Blue(9), Green(10), Cyan(11), Red(12), Magenta(13), Yellow(14), White(15): ");
                                        int.TryParse(Console.ReadLine(), out int rectangleColor);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.WriteLine("                                                                                                                      ");
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        Rectangle rectangle = new Rectangle((ConsoleColor)rectangleColor, rectangleSymbol, rectangleX, rectangleY, rectangleLenght, rectangleHeight);
                                        rectangle.Draw();
                                        break;
                                    }
                                case "3":
                                    { 
                                        Console.Write("Введите X левого нижнего угла треугольника: ");
                                        int.TryParse(Console.ReadLine(), out int triangleX);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (triangleX < 0)
                                        {
                                            triangleX = 0;
                                        }

                                        Console.Write("Введите Y левого нижнего угла треугольника: ");
                                        int.TryParse(Console.ReadLine(), out int triangleY);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (triangleY < 0)
                                        {
                                            triangleY = 0;
                                        }

                                        Console.Write("Введите длину треугольника: ");
                                        int.TryParse(Console.ReadLine(), out int triangleLenght);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (triangleLenght < (triangleY + 1) * 2 + 1)
                                        {
                                            triangleLenght = (triangleY + 1) * 2 - 2;
                                        }

                                        Console.Write("Введите символ, которым будет выведен треугольник: ");
                                        char.TryParse(Console.ReadLine(), out char triangleSymbol);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);
                                        if (triangleSymbol == ' ')
                                        {
                                            triangleSymbol = '*';
                                        }

                                        Console.WriteLine("Введите цвет треугольника: ");
                                        Console.WriteLine("Black(0), DarkBlue(1), DarkGreen(2), DarkCyan(3), DarkRed(4), DarkMagenta(5), DarkYellow(6), Gray(7)");
                                        Console.Write("DarkGray(8), Blue(9), Green(10), Cyan(11), Red(12), Magenta(13), Yellow(14), White(15): ");
                                        int.TryParse(Console.ReadLine(), out int triangleColor);
                                        Console.SetCursorPosition(0, 0);
                                        Console.WriteLine("                                                                                           ");
                                        Console.WriteLine("                                                                                                                      ");
                                        Console.WriteLine("                                                                                           ");
                                        Console.SetCursorPosition(0, 0);

                                        Triangle triangle = new Triangle((ConsoleColor)triangleColor, triangleSymbol, triangleX, triangleY, triangleLenght);
                                        triangle.Draw();
                                        break;
                                    }
                            }
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            break;
                        }
                    case "3":
                        {
                            in_cycle = false;
                            break;
                        }
                }
            }
        }
    }
}
