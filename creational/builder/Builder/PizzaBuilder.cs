public abstract class PizzaBuilder {
    protected Pizza Pizza {get;set;}

    public virtual void CriaPizza(){
        Pizza = new Pizza();
    }
    public virtual Pizza GetPizza(){
        return Pizza;
    }

    public abstract void PrepararMassa();
    public abstract void IncluirIngredientes();
}