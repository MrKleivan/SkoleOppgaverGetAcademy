namespace Emne3Oppgaver.Oppgave324A;

public class FootballMatch(string bet)
{
    private string _bet = bet;
    private int _awayGoals;
    private int _homeGoals;
    private bool _isActive;
    public string Score => !_isActive ? "" : _awayGoals == _homeGoals ? "U" : _awayGoals > _homeGoals ? "B" : "H";

    public void AddGoal(string team)
    {
        if (team is "B")
        {
            _awayGoals++;
        }
        else if (team is "H")
        {
            _homeGoals++;
        }
        else if (team is "X")
        {
            _isActive = true;
        }
    }

    public bool IsBetCorrect()
    {
        if(_bet == Score) return true;
        return false;
    }
    
    
}