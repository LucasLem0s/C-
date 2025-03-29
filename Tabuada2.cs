
using System;
class Program {
  static void Main() {
    bool continuar = true;
    
    while (continuar){  
        
        Console.WriteLine("Digite um numero:");
        double tabuada = double.Parse(Console.ReadLine());
        
        for (int i = 1; i <=10 ; i++ ){
            Console.WriteLine($"{i} x {tabuada} = {i*tabuada}");
        }
        Console.WriteLine("Deseja fazer outra tabuada?\n Sim ou Não?");
        string resposta = Console.ReadLine().ToLower();
        if (resposta == "sim"){
        continuar = true;
        }
        else if (resposta == "não"){
        Console.WriteLine("Obrigado e volte sempre!");
        continuar = false;
        }
        else{
        continuar = false;
        Console.WriteLine("Valor invalido, tente novamente!");
        }
    
    }
  }
}