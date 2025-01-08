using System;


namespace DZ1.Classes
{
    abstract class Game
    {
        public abstract string Name { get; }
        public abstract void Play();

        public void StartGame()
        {
            Console.WriteLine($"Игра началась: {Name}");
            Play();
            Console.WriteLine($"Игра закончилась: {Name}\n");
        }
    }
}
