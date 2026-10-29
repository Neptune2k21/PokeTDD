namespace PokerTDD;

public class EvaluateurPoker
{
    public int Evaluer(IEnumerable<Carte> main)
    {
        var cartes = main.ToList();

        bool contientBrelan = cartes
            .GroupBy(carte => carte.value)
            .Any(groupe => groupe.Count() >= 3);

        if (contientBrelan)
        {
            return 30;
        }

        var valeurs = cartes
            .Select(carte => carte.value)
            .OrderBy(valeur => valeur)
            .ToList();

        bool contientSuite = valeurs
            .Distinct()
            .Count() == 5
            && valeurs[4] - valeurs[0] == 4;

        if (contientSuite)
        {
            return 40;
        }

        return cartes.Max(carte => carte.value);
    }
}
