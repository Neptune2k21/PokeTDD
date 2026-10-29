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
    [Fact]
    public void Evaluer_AvecUnFull_Retourne50Points()
    {
        var main = new[]
        {
            new Carte(2, Enseigne.Coeur),
            new Carte(2, Enseigne.Pique),
            new Carte(2, Enseigne.Carreau),
            new Carte(9, Enseigne.Trefle),
            new Carte(9, Enseigne.Pique)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(50, resultat);
    }
    [Fact]
    public void Evaluer_AvecUnCarre_Retourne60Points()
    {
        var main = new[]
        {
            new Carte(4, Enseigne.Coeur),
            new Carte(4, Enseigne.Pique),
            new Carte(4, Enseigne.Carreau),
            new Carte(4, Enseigne.Trefle),
            new Carte(13, Enseigne.Coeur)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(60, resultat);
    }
    [Fact]
    public void Evaluer_AvecUneQuinteFlush_Retourne80Points()
    {
        var main = new[]
        {
            new Carte(5, Enseigne.Coeur),
            new Carte(6, Enseigne.Coeur),
            new Carte(7, Enseigne.Coeur),
            new Carte(8, Enseigne.Coeur),
            new Carte(9, Enseigne.Coeur)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(80, resultat);
    }
    [Fact]
    public void Evaluer_AvecAsDeuxTroisQuatreCinq_Retourne14Points()
    {
        var main = new[]
        {
            new Carte(14, Enseigne.Coeur),
            new Carte(2, Enseigne.Pique),
            new Carte(3, Enseigne.Carreau),
            new Carte(4, Enseigne.Trefle),
            new Carte(5, Enseigne.Coeur)
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.Evaluer(main);

        Assert.Equal(14, resultat);
    }

    [Fact]
    public void CalculerTotal_AvecLesMainsDeExemple_Retourne148Points()
    {
        var mains = new List<MainPoker>
        {
            new(new[]
            {
                new Carte(2, Enseigne.Coeur),
                new Carte(2, Enseigne.Pique),
                new Carte(2, Enseigne.Carreau),
                new Carte(9, Enseigne.Trefle),
                new Carte(9, Enseigne.Pique)
            }),

            new(new[]
            {
                new Carte(5, Enseigne.Trefle),
                new Carte(6, Enseigne.Carreau),
                new Carte(7, Enseigne.Coeur),
                new Carte(8, Enseigne.Pique),
                new Carte(9, Enseigne.Trefle)
            }),

            new(new[]
            {
                new Carte(2, Enseigne.Coeur),
                new Carte(7, Enseigne.Coeur),
                new Carte(9, Enseigne.Coeur),
                new Carte(11, Enseigne.Coeur),
                new Carte(13, Enseigne.Coeur)
            }),

            new(new[]
            {
                new Carte(3, Enseigne.Trefle),
                new Carte(8, Enseigne.Carreau),
                new Carte(10, Enseigne.Coeur),
                new Carte(12, Enseigne.Pique),
                new Carte(13, Enseigne.Trefle)
            })
        };

        var evaluateur = new EvaluateurPoker();

        int resultat = evaluateur.CalculerTotal(mains);

        Assert.Equal(148, resultat);
    }







}

