namespace Poke.Iterfaces;

public interface IType
{
    // enum de tipos de poke
    public enum PokemonType
    {
        Fuego,
        Agua,
        Aire,
        Tierra,
        Dragon,
        Hada
    }
    
    void Ventajas(PokemonType tipo);
}
