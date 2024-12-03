namespace Emne3Oppgaver.Oppgave324A;

public class Coupon
{
    public FootballMatch[] _coupon;

    public Coupon(string? betsText)
    {
        var bets = betsText.Split(",");
        _coupon = new FootballMatch[bets.Length];
        for (int i = 0; i < bets.Length; i++)
        {
            _coupon[i] = new FootballMatch(betsText[i].ToString());
        }
    }
}