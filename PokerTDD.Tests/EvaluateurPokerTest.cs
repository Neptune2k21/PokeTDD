namespace PokerTDD.Tests;

public class EvaluateurPokerTest
{
    [Fact]
    public void Brelan_Rapport30Points()
    {
        var _evaluateur = new EvaluateurPoker();

        var main = new[]
            {
                new Carte(2, Enseigne.Coeur),
                new Carte(2, Enseigne.Pique),
                new Carte(2, Enseigne.Carreau),
                new Carte(9, Enseigne.Trefle),
                new Carte(13, Enseigne.Pique)
            };

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

[Fact]
    public void Evaluer_AvecUneSuite_Retourne40Points()
    {
        var main = new[]
        {
            new Carte(5, Enseigne.Trefle),
            new Carte(6, Enseigne.Carreau),
            new Carte(7, Enseigne.Coeur),
            new Carte(8, Enseigne.Pique),
            new Carte(9, Enseigne.Trefle)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(40, resultat);
    }
    [Fact]
    public void Evaluer_AvecUneCouleur_Retourne45Points()
    {
        var main = new[]
        {
            new Carte(2, Enseigne.Coeur),
            new Carte(5, Enseigne.Coeur),
            new Carte(8, Enseigne.Coeur),
            new Carte(11, Enseigne.Coeur),
            new Carte(13, Enseigne.Coeur)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(45, resultat);
    }


}

