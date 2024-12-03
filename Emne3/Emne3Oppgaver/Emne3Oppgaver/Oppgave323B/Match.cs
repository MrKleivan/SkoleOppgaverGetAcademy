namespace Emne3Oppgaver.Oppgave323B;

public class Match(string bet)
{
    private string _bet = bet;
    private int _homeGoals = 0;
    private int _awayGoals = 0;
    private bool _isActive = true;
    // string Result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";

    public static Match[] CreateCoupon(string? betsText)
    {
        var matches = new Match[12];
        if (betsText != null)
        {
            var bets = betsText.Split(',');
            for (var i = 0; i < 12; i++)
            {
                matches[i] = new Match(bets[i]);
            }
        }
        return matches;
    }

    public static void ShowPlayedMatches(Match[] matches, int correctCount)
    {
        for (var index = 0; index < matches.Length; index++)
        {
            var match = matches[index];
            if (match._isActive == true) continue;
            var theMatchNo = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {theMatchNo}: {match.GetScore()} - {match.GetResult()} - {isBetCorrectText}");
        }
    }
      
    public void AddGoal(string command)
    {
        if (command == "H") {_homeGoals++;}
        else if (command == "B") {_awayGoals++;}
        else if (command == "X") {_isActive = false;}
    }

    string GetScore()
    {
        var score = $"Ferdig med resultat: {_homeGoals} - {_awayGoals}";

        return score;
    }

    string GetResult()
    {
        string result;
        if (_isActive == false)
        {
            result = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
        }
        else
        {
            result = "Kampen er ikke ferdig";
        }
        return result;
    }

    bool IsBetCorrect()
    {
        if (_bet == GetResult())
        {
            return true;
        }
        return false;
    }
    // public string ShowResult(string bet)
    // {
    //     var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
    //     var isBetCorrect = bet.Contains(result);
    //     var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
    //         
    //         
    //     return isBetCorrectText; 
    // }
}