using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");


    Console.WriteLine ("Inserisci il tuo nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine ("ciao " + nome + "!");
    Console.WriteLine ("Inserisci un numero:");
    int numero = int.Parse(Console.ReadLine());
    Console.WriteLine ("Inserisci un altro numero:");
    int numero2 = int.Parse(Console.ReadLine());
    Console.WriteLine ("Ecco la loro somma: " + numero + numero2);
  }
}