using System;

public class Cafe : Bebida
{

    //Atributos
    public string Tipo {get; private set;}

    //Construtor
    public Cafe (string nome, decimal preco, string tamanho, string tipo): base (nome, preco, tamanho)
    {
        Tipo = tipo;
        Preco = CalcularPreco();
    }

    //Métodos
    public override decimal CalcularPreco()
    {
        Preco = Tamanho == "Grande" ? Preco*2 : Preco;       //Lógica IF-ELSE (Expressão ternária)
        return Preco;
    }

    //ToString
    public override string ToString()
    {
        return $"Nome: {Nome}, Preco:{Preco:C}, Tamanho {Tamanho}, Tipo: {Tipo}";
    }

}