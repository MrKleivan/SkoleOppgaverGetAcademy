namespace Emne3Oppgaver.Oppgave323B1;

public class Match(string bet)
{
    string _bet = bet;
    int _homeGoals; 
    int _awayGoals;
    public string LeadingTeam => _homeGoals == _awayGoals ? "U" : "B";
    public bool IsComplete {get; private set;}
    
    public void AddGoal(string team)
    {
        if (team == "H") _homeGoals++;
        else if (team == "B") _awayGoals++;
        else if (team == "X") IsComplete = true;
    }

    public string GetScore()
    {
        var text = "Ikke ferdig";
        if (IsComplete)
        {
            text = $"{_homeGoals} : {_awayGoals} |{(_homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B")}|";
        }
        return text;
    }

    public bool IsBetCorrect()
    {
        string? score;
        if (IsComplete)
        {
            score = _homeGoals == _awayGoals ? "U" : _homeGoals > _awayGoals ? "H" : "B";
        }
        else score = null;
        return _bet == score;
    }

    public string GetIsBetCorrectText(bool isBetCorrect)
    {
        if (IsComplete)
        {
            if (!isBetCorrect) return "Feil";
            else return "Riktig";
        }

        return "";
    }
}