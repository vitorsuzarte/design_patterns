public class PizzaDirector {
    private PizzaBuilder PizzaBuilder {get;set;}

    public PizzaDirector(PizzaBuilder builder){
        PizzaBuilder = builder;
    }
    
    //Construct
    public void MontaPizza(){
        PizzaBuilder.CriaPizza();
        PizzaBuilder.PrepararMassa();
        PizzaBuilder.IncluirIngredientes();
    }

    public Pizza GetPizza(){
        return PizzaBuilder.GetPizza();
    }
}