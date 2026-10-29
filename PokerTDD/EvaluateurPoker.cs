
namespace PokerTDD;

public class EvaluateurPoker
{
    public int Evaluer(IEnumerable<Carte> main)
    {
        var cartes = main.ToList();

        var groupes = cartes
            .GroupBy(carte => carte.value)
            .Select(groupe => groupe.Count())
            .OrderByDescending(nombre => nombre)
            .ToList();

        var values = cartes
            .Select(carte => carte.value)
            .OrderBy(value => value)
            .ToList();

        bool contientSuite = values.Distinct().Count() == 5
            && values[4] - values[0] == 4;

        bool contientCouleur = cartes
            .Select(carte => carte.Enseigne)
            .Distinct()
            .Count() == 1;

        if (contientSuite && contientCouleur)
        {
            return 80;
        }

        if (groupes[0] == 4)
        {
            return 60;
        }

        if (groupes[0] == 3 && groupes[1] == 2)
        {
            return 50;
        }

        if (groupes[0] >= 3)
        {
            return 30;
        }

        if (contientSuite)
        {
            return 40;
        }

        if (contientCouleur)
        {
            return 45;
        }

        return cartes.Max(carte => carte.value);
    }

    public int CalculerTotal(IEnumerable<MainPoker> mains)
    {
        return mains.Sum(main => Evaluer(main.Cartes));
    }

}
