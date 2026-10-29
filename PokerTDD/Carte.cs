namespace PokerTDD;

public enum Enseigne
{
    Coeur,
    Pique,
    Carreau,
    Trefle
}

public sealed record Carte (int value, Enseigne Enseigne);
