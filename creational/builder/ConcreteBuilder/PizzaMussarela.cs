public sealed class PizzaMussarela : PizzaBuilder {
    public override void PrepararMassa(){
        Pizza.Massa = Massa.Artesanal;
        Pizza.Borda = Borda.Tradicional;
        Pizza.Tamanho = Tamanho.Pequeno;
    }
    public override void IncluirIngredientes(){
        Pizza.Ingredientes = new List<Ingredientes>(){
            Ingredientes.Queijo,
            Ingredientes.Tomate,
        };
    }
}