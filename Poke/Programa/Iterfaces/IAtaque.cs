using Poke.Clases;

namespace Poke.Iterfaces;


public interface IAtaque
{
    void CalcularDanio(Pokemon atacante, Pokemon defensor); 
}
