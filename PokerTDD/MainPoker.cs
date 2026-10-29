namespace PokerTDD;

public sealed class MainPoker
{
    public IReadOnlyList<Carte> Cartes { get; }

    public MainPoker(IEnumerable<Carte> cartes)
    {
        Cartes = cartes.ToList();

        if (Cartes.Count != 5)
        {
            throw new ArgumentException(
                "Une main doit contenir exactement 5 cartes.");
        }
    }
}
