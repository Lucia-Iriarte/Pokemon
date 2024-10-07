namespace Poke.Clases;

public class Pokemon
{

    public string Nombre { get; set; }
    public double HP { get; set; }
    public double Ataque { get; set; }
    public double Defensa { get; set; }
    
    public Pokemon(string nombre, double salud, double ataque, double defensa)
    {
        Nombre = nombre;
        HP = salud;
        Ataque = ataque;
        Defensa = defensa;
    }
}