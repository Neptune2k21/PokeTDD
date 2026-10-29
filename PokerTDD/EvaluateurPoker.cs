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

        return cartes.Max(carte => carte.value);
    }
}