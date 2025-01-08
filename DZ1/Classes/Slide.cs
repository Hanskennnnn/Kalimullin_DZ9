using System;


namespace DZ1.Classes
{
    class Slide : Game
    {
        public override string Name => "Горка";
        public override void Play() => Console.WriteLine("Команды соревнуются в быстром скатывании с горки!");
    }
}
