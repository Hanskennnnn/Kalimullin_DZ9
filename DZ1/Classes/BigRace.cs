using System;
using System.Collections.Generic;


namespace DZ1.Classes
{
    class BigRace
    {
        private List<Team> Teams = new List<Team>();
        private List<Game> Games = new List<Game>();

        public void AddTeam(Team team) => Teams.Add(team);

        public void AddGame(Game game) => Games.Add(game);

        public void StartCompetition()
        {
            Console.WriteLine("Большие гонки начинаются!");
            foreach (var team in Teams)
            {
                Console.WriteLine($"Команда: {team.Name}");
            }

            foreach (var game in Games)
            {
                game.StartGame();
            }

            Console.WriteLine("Большие гонки закончились!");
        }
    }
}
