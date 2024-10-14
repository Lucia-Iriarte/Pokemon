using Poke.Clases;

namespace Poke.Iterfaces;


public interface IAtaque 
{
    // Atributos
    string Name { get; set; }
    int Danio { get; set; }
    IType.PokemonType Type { get; set; } 
    bool EsEspecial { get; set; }
   
    void CalcularDanio(Pokemon atacante, Pokemon defensor); //metodo
}
