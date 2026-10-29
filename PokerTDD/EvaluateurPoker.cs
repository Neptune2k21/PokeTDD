namespace PokerTDD;

public class EvaluateurPoker
{
    public int Evaluer(IEnumerable<Carte> main)
    {
        return main.Max(carte => carte.value);
    }
}