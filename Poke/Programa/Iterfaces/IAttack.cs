using Poke.Clases;

namespace Poke.Iterfaces;


public interface IAttack
{
    void CalcularDanio(Pokemon atacante, Pokemon defensor); 
}
