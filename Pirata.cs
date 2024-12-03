public class Pirata
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Barco { get; set; }

    public Pirata(string nombre, int edad, string barco)
    {
        Nombre = nombre;
        Edad = edad;
        Barco = barco;
    }

    public void Presentarse()
    {
        Console.WriteLine($"Soy {Nombre}, tengo {Edad} años y navego en el barco {Barco}");
    }

    //Método atacar
    public void Atacar()
    {
        Console.WriteLine($"Soy {Nombre} y estoy atacando");
    }

    public override string ToString()
    {
        return $"Pirata(Nombre={Nombre}, Edad={Edad}, Barco={Barco})";
    }
}