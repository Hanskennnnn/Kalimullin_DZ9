using System;


namespace DZ1.Classes
{
    class Beach : Game
    {
        public override string Name => "Пляж";
        public override void Play() => Console.WriteLine("Команды соревнуются в строительстве замков из песка!");
    }
}
