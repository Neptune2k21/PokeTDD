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
    [Fact]
    public void Evaluer_SansCombinaison_RetourneLaCarteHaute()
    {
        var main = new[]
        {
            new Carte(3, Enseigne.Trefle),
            new Carte(6, Enseigne.Carreau),
            new Carte(8, Enseigne.Coeur),
            new Carte(12, Enseigne.Pique),
            new Carte(13, Enseigne.Trefle)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(13, resultat);
    }
}

