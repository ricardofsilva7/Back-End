using System;

#pragma warning disable CS9107 // Parameter is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.
public class Sobremesa (string nome, decimal preco, string sabor): Item(nome,preco)
#pragma warning restore CS9107 // Parameter is captured into the state of the enclosing type and its value is also passed to the base constructor. The value might be captured by the base class as well.
{
    public string Sabor {get; private set;} = sabor;

    public override decimal CalcularPreco()
    {
        return base.CalcularPreco();
    }

    //ToString()
    public override string ToString()
    {
        return $"Sobremesa: {nome} - Preco{preco} - Sabor: {Sabor}";
    }
}