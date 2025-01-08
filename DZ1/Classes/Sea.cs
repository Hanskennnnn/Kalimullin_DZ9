using System;


namespace DZ1.Classes
{
    class Sea : Game
    {
        public override string Name => "Море";
        public override void Play() => Console.WriteLine("Команды гребут на лодках наперегонки!");
    }

}
