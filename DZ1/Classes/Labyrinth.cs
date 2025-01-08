using System;

namespace DZ1.Classes
{
    class Labyrinth : Game
    {
        public override string Name => "Лабиринт";
        public override void Play() => Console.WriteLine("Команды соревнуются в поиске выхода из лабиринта!");
    }
}
