public class Pizza{

    public Massa Massa { get; set; }
    public Borda Borda { get; set; }
    public Tamanho Tamanho { get; set; }
    public List<Ingredientes> Ingredientes {get;set;}
    public int TempoPreparo { get; set; }

    public void LogarPizzaMontada(){
        Console.WriteLine($"Pizza com massa: {Massa} ");
        Console.WriteLine($"Tipo da borda: {Borda} ");
        Console.WriteLine($"Tamanho da pizza: {Tamanho} ");
        Console.WriteLine("Ingredientes:");
        Ingredientes.ForEach( i => Console.WriteLine($"  {i}"));
    }
}