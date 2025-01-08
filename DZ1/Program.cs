using DZ1.Classes;
using System;


namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1");

            var teamRussia = new Team("Россия");
            var teamFrance = new Team("Франция");
            var teamChina = new Team("Китай");
            var teamKazakhstan = new Team("Казахстан");

            var bigRace = new BigRace();
            bigRace.AddTeam(teamRussia);
            bigRace.AddTeam(teamFrance);
            bigRace.AddTeam(teamChina);
            bigRace.AddTeam(teamKazakhstan);


            bigRace.AddGame(new Beach());
            bigRace.AddGame(new MouseTrap());
            bigRace.AddGame(new Sea());
            bigRace.AddGame(new Fishing());
            bigRace.AddGame(new Postmen());
            bigRace.AddGame(new Slide());


            bigRace.AddGame(new Labyrinth());


            bigRace.StartCompetition();
        }
    }
}
