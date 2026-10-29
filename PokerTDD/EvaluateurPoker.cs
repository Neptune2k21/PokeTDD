namespace PokerTDD;

public class EvaluateurPoker
{
    public int Evaluer(IEnumerable<Carte> main)
    {
        var cartes = main.ToList();

        var groupes = cartes
            .GroupBy(carte => carte.value)
            .Select(groupe => groupe.Count())
            .ToList();

        if (groupes.Any(nombre => nombre >= 3))
        {
            return 30;
        }

        var valeurs = cartes
            .Select(carte => carte.value)
            .OrderBy(valeur => valeur)
            .ToList();

        bool contientSuite = valeurs.Distinct().Count() == 5
            && valeurs[4] - valeurs[0] == 4;

        if (contientSuite)
        {
            return 40;
        }

        bool contientCouleur = cartes
            .Select(carte => carte.Enseigne)
            .Distinct()
            .Count() == 1;

        if (contientCouleur)
        {
            return 45;
        }

        return cartes.Max(carte => carte.value);
    }
}
