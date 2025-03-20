using System;
class Program {
  static void Main() {
      
    string numero;
    
    Console.WriteLine("Digite um numero de 1 a 7");
    numero = Console.ReadLine ();
    
    switch (numero){
        case("1"):
            Console.WriteLine("Domingo");
            break;
        case("2"):
            Console.WriteLine("Segunda-feira");
            break;
             case("3"):
            Console.WriteLine("Terça-feira");
            break;
             case("4"):
            Console.WriteLine("Quarta-feira");
            break;
             case("5"):
            Console.WriteLine("Quinta-feira");
            break;
             case("6"):
            Console.WriteLine("Sexta-feira");
            break;
             case("7"):
            Console.WriteLine("Sabado");
            break;
            default:
            Console.WriteLine("Numero invalido, digite um numero de 1 a 7");
            break;
    }
  }
}