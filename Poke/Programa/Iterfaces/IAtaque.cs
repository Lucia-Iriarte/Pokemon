namespace Poke.Iterfaces;

public interface IAtaque
{
    // Atributos
    string Name { get; set; }
    int Danio { get; set; }
    string Type { get; set; } // Habria que relacionarlo con Itype!!!
    bool EsEspecial { get; set; }
    
    // Metodos
    void CalcularDanio();
}