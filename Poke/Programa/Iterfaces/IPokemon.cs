using Poke.Clases;

namespace Poke.Iterfaces;

public interface IPokemon
{ 
    // Atributos
    string Name { get; set; }
    int HP { get; set; }
    string Type { get; set; }
    
    // Metodos
    string EstaVivo();
    void Atacar();
    void RecibirDanio();
    void AddAtaque(string nuevoAtaque);
}