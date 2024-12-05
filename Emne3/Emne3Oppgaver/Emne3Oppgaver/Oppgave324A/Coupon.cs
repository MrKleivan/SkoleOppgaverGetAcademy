namespace Emne3Oppgaver.Oppgave324A;

public class Coupon
{
    public FootballMatch[] _coupon;

    public Coupon(string[] bets)
    {
        
        _coupon = new FootballMatch[bets.Length];
        for (int i = 0; i < bets.Length; i++)
        {
            _coupon[i] = new FootballMatch(bets[i].ToString());
        }
    }

    public void ShowCoupon(string team, int matchNo)
    {
        var selectedIndex = matchNo - 1;
        var selectedMatch = _coupon[selectedIndex];
        selectedMatch.AddGoal(team);
        var correctCount = 0;
        
        for (var index = 0; index < _coupon.Length; index++)
        {
            var match = _coupon[index];
            var theMatchNo = index + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = _coupon[index]._isActive ? isBetCorrect ? "riktig" : "feil" : "";
            if (isBetCorrect) correctCount++;
            Console.WriteLine($"Kamp {theMatchNo}: {match.Score} - {isBetCorrectText}");
        }
        Console.WriteLine($"Du har {correctCount} rette.");
    }
}