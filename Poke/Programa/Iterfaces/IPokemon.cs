using Poke.Clases;

namespace Poke.Iterfaces;

public interface IPokemon
{ 
    string EstaVivo();
    void Atacar();
    void RecibirDanio();
    void AddAtaque(string nuevoAtaque);
}