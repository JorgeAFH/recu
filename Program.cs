using System;
namespace Recuperacion;

public class Recuperacion
{
    public static void Main(string[] args)
    {
        Console.Clear();
        //base de taco
        var taco = new taco();
        Console.WriteLine(taco.Calcular() + " :");
        //taco + carne
        var carne = new carne(taco);
        Console.WriteLine(" + carne : " +carne.Calcular());
        //taco + pollo
        var pollo = new pollo(taco);
        Console.WriteLine(" + pollo : " +pollo.Calcular());
        //taco + chile
        var chile = new chile(taco);
        Console.WriteLine(" + chile : " +chile.Calcular());

        //taco + chile + carne
        Console.WriteLine(carne.Calcular()+chile.precioc + " de chile con carne");

        //-----------------------------------------------------------------
        Console.WriteLine();
        //base de tamal
        var tamal = new tamal();
        Console.WriteLine(tamal.Calcular() + " :");

        var carne2 = new carne(tamal);
        Console.WriteLine(" + carne : " +carne2.Calcular());
        //taco + pollo
        var pollo2 = new pollo(tamal);
        Console.WriteLine(" + pollo : " +pollo2.Calcular());
        //taco + chile
        var chile2 = new chile(tamal);
        Console.WriteLine(" + chile : " +chile2.Calcular());
        
    }
}
