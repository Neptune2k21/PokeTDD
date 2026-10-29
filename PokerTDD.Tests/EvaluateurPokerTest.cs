namespace PokerTDD.Tests;

public class EvaluateurPokerTest
{
    [Fact]
    public void Brelan_Rapport30Points()
    {
        var _evaluateur = new EvaluateurPoker();

        var main = CreerMain(
            new(2, Enseigne.Coeur),
            new(2, Enseigne.Pique),
            new(2, Enseigne.Carreau),
            new(9, Enseigne.Trefle),
            new(13, Enseigne.Pique));

        Assert.Equal(30, _evaluateur.Evaluer(main));
    }
}

