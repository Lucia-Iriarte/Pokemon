using Poke.Clases;

namespace Poke.Iterfaces;

public interface IPokemon
{ 
    string EstaVivo();
    void Atacar();
    void RecibirDanio(double danio);
    void AddAtaque(Attack nuevoAtaque);
    List<Attack> GetAtaques();
    Clases.Type GetTipo();
    double GetHp();
}