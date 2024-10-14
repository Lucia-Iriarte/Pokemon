using Poke.Clases;

namespace Poke.Iterfaces;

public interface IPokemon
{ 
    string EstaVivo();
    void Atacar();
    void RecibirDanio(double danio);
    void AddAtaque(Ataque nuevoAtaque);
    List<Ataque> GetAtaques();
    Clases.Type GetTipo();
    double GetHp();
}