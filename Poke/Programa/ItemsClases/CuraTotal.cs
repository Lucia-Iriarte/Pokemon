namespace Poke.Clases;

public class CuraTotal : Items
{
    public CuraTotal()
    {
        Nombre = "Cura Total";
    }

    public override void Usar(Pokemon objetivo)
    {
        //eliminamos efectos 
        objetivo.EstadoDormido = null;
        objetivo.Paralizado = false;
        objetivo.Envenenado = false;
        objetivo.Quemado = false;
        objetivo.estado = null;  
        Console.WriteLine($"{objetivo.Nombre} ha sido curado  de todos los efectos de estado.");
    }
}
