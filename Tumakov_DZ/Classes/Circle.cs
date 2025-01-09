using System;


namespace DZ.Classes
{
    public class Circle : Point
    {
        public double Radius { get; set; }

        public Circle(string color, bool isVisible, int x, int y, double radius)
            : base(color, isVisible, x, y)
        {
            Radius = radius;
        }

    
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Display()
        {
            Console.WriteLine($"Фигура: Окружность, Цвет: {Color}, Видимость: {IsVisible}, Координаты: ({X}, {Y}), Радиус: {Radius}, Площадь: {GetArea():F2}");
        }
    }
}
