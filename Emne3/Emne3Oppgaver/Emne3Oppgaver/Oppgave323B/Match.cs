namespace Emne3Oppgaver.Oppgave323B;

public class Match
{
    public static int HomeGoals;
    public static int AwayGoals;
    public int[] bets = [12];

      
    public static void CreateGameGoals(string bet, string command)
    {
        if (command == "H") HomeGoals++;
        else if (command == "B") AwayGoals++;
    }
    public static string ShowResult(string bet)
    {
        var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        var isBetCorrect = bet.Contains(result);
        var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            
            
        return isBetCorrectText; 
    }
}