namespace Emne3Oppgaver.Oppgave323B1;

public class TwelveMatches
{
    private readonly Match[] Matches = new Match[12];
    
    
    public TwelveMatches(string betsText)
    {
        var bets = betsText.Split(',');
        
        for (var i = 0; i < 12; i++)
        {
            if (bets != null) Matches[i] = new Match(bets[i]);
        }
        
    }

    public int Length() => Matches.Length;


    public Match GetMatch(int selectedIndex)
    {
        return Matches[selectedIndex];
    }
    

    public int Count;
    public void CreateCoupon(string? team, int matchNo, TwelveMatches matches)
    {
        var selectedIndex = matchNo - 1;
        var selectedMatch = matches.GetMatch(selectedIndex);
        if (team != null) selectedMatch.AddGoal(team);
        var correctCount = 0;
        for (var index = 0; index < matches.Length(); index++)
        {
            var match = matches.GetMatch(index);
            if (match.IsComplete == false) continue;
            var theMatchNo = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = match.GetIsBetCorrectText(isBetCorrect);
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {theMatchNo}: {match.GetScore()} - {isBetCorrectText}");
        }
        
        Count = correctCount;
    }
}