using System;


namespace DZ1.Classes
{
    class Fishing : Game
    {
        public override string Name => "Рыбалка";
        public override void Play() => Console.WriteLine("Команды ловят рыбу и соревнуются по улову!");
    }
}
