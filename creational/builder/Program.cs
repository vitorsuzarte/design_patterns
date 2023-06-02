using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Pizza de Calabresa");
        var pizzaDirector = new PizzaDirector(new PizzaCalabresa());
        pizzaDirector.MontaPizza();
        var primeiroPedido = pizzaDirector.GetPizza();
        primeiroPedido.LogarPizzaMontada();

        // RealizarPedido<PizzaCalabresa>();
        // RealizarPedido<PizzaMussarela>();
    }


    // public static void RealizarPedido<T>() where T : Pizza {
    //     var pizzaDirector = new PizzaDirector(new T());
    //     pizzaDirector.MontaPizza();
    //     var primeiroPedido = pizzaDirector.GetPizza();
    //     primeiroPedido.LogarPizzaMontada();
    // }

}
