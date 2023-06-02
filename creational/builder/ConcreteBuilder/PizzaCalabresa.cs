public sealed class PizzaCalabresa : PizzaBuilder {
    public override void PrepararMassa(){
        Pizza.Massa = Massa.Tradicional;
        Pizza.Borda = Borda.Catupiry;
        Pizza.Tamanho = Tamanho.Grande;
    }
    public override void IncluirIngredientes(){
        Pizza.Ingredientes = new List<Ingredientes>(){
            Ingredientes.Queijo,
            Ingredientes.Calabresa,
        };
    }
}