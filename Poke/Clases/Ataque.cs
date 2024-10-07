namespace Poke.Clases;

public class Ataque
{
    //constructor
    public string Nombre { get; set; }        
    public string Tipo { get; set; }        
    public double Efectividad { get; set; } 
    
    public Ataque(string nombre, string tipo, double efectividad)
    {
        Nombre = nombre;
        Tipo = tipo;
        Efectividad = efectividad;
    }

    public bool esEspecial()
    {
        return 
    }

    public double calcularDanio()
    {
        return 
    }
}