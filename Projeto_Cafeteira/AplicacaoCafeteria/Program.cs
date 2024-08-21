using System;

public class Program
{
    public static void Main(String[] args)
    {
        Item item = new Item("Pão de queijo", 5.90m);
        Console.WriteLine(item);


        Bebida bebida = new Cafe ("Capuccino",4.00m,"Grande", "Expresso");

        Console.WriteLine(bebida);

        Item sobremesa = new Sobremesa("Bolo",9.80m,"Morango");
        Console.WriteLine(sobremesa);
    }





}