using DZ.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ.Classes
{
    public class Point : IFigure
    {
        public string Color { get; set; } 
        public bool IsVisible { get; set; } 
        public int X { get; set; } 
        public int Y { get; set; } 

        public Point(string color, bool isVisible, int x, int y)
        {
            Color = color;
            IsVisible = isVisible;
            X = x;
            Y = y;
        }

        public virtual void MoveHorizontal(int deltaX)
        {
            X += deltaX;
        }

        public virtual void MoveVertical(int deltaY)
        {
            Y += deltaY;
        }

        public void ChangeColor(string newColor)
        {
            Color = newColor;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Фигура: Точка, Цвет: {Color}, Видимость: {IsVisible}, Координаты: ({X}, {Y})");
        }
    }
}
