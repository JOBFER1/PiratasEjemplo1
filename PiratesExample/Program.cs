class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("¡Hola, mundo!");
        List<Pirata> piratas = new List<Pirata>
        {
            new Pirata("Barbanegra", 40, "Venganza de la Reina Ana"),
            new Pirata("Anne Bonny", 29, "Revenge"),
            new Pirata("Calico Jack", 35, "William")
        };

        foreach (var pirata in piratas)
        {
            pirata.Presentarse();
            pirata.Atacar();
        }

    }
}