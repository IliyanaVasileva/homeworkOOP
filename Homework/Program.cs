using Homework;

internal class Program
{
    private static void Main(string[] args)
    {
        FootballPlayer player = new FootballPlayer();
        Defender defender = new Defender(); 
        Midfield midfield = new Midfield();
        Striker striker = new Striker();
        GoalKeeper goalKeeper = new GoalKeeper();
        Referee referee = new Referee();
        Coach coach= new Coach();
        Team team = new Team();
        Game game = new Game(); 
        if (game.FootballTeam1.Players.Count != 11 && game.FootballTeam2.Players.Count != 11)
        {
            Console.WriteLine("FootballTeam1 and FootballTeam2 must have exactly 11 players.");
            
        }
        else
        {
            return;
        }
        

    }
}