using System;


namespace DZ1.Classes
{
    class MouseTrap : Game
    {
        public override string Name => "Мышеловка";
        public override void Play() => Console.WriteLine("Команды соревнуются в ловкости и избегают ловушек!");
    }
}
