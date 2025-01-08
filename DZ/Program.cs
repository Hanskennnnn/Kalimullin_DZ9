using DZ.Classes;
using DZ.Interfaces;
using System;


namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1");
            string text = "Привет Мир";

            ICipher aCipher = new ACipher();
            string aEncoded = aCipher.Encode(text);
            string aDecoded = aCipher.Decode(aEncoded);

            Console.WriteLine("ACipher:");
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Encoded: {aEncoded}");
            Console.WriteLine($"Decoded: {aDecoded}");

            ICipher bCipher = new BCipher();
            string bEncoded = bCipher.Encode(text);
            string bDecoded = bCipher.Decode(bEncoded);

            Console.WriteLine("\nBCipher:");
            Console.WriteLine($"Original: {text}");
            Console.WriteLine($"Encoded: {bEncoded}");
            Console.WriteLine($"Decoded: {bDecoded}");
            Console.WriteLine("\n\n\n");
        }
        static void Task2()
        {
            Console.WriteLine("Задание 2");
            Point point = new Point("Красный", true, 0, 0);
            point.Display();
            point.MoveHorizontal(5);
            point.MoveVertical(3);
            point.Display();

            Circle circle = new Circle("Синий", true, 10, 10, 5);
            circle.Display();

            Rectangle rectangle = new Rectangle("Зелёный", true, 15, 20, 8, 4);
            rectangle.Display();
            rectangle.MoveHorizontal(7);
            rectangle.MoveVertical(-25);
            rectangle.Display();
        }
    }
}
