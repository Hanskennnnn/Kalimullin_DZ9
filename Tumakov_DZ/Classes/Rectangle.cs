using System;


namespace DZ.Classes
{
    public class Rectangle : Point
    {
        public double Width { get; set; } 
        public double Height { get; set; } 

        public Rectangle(string color, bool isVisible, int x, int y, double width, double height)
            : base(color, isVisible, x, y)
        {
            Width = width;
            Height = height;
        }

     
        public double GetArea()
        {
            return Width * Height;
        }

        public override void Display()
        {
            Console.WriteLine($"Фигура: Прямоугольник, Цвет: {Color}, Видимость: {IsVisible}, Координаты: ({X}, {Y}), Ширина: {Width}, Высота: {Height}, Площадь: {GetArea():F2}");
        }
    }
}
