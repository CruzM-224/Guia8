using System;

class MainClass {
  public static void Main (string[] args) {
    string letra;

    while(true){
      Console.WriteLine("Menu de operaciones. \n");
      Console.WriteLine("a) Dividir. \n");
      Console.WriteLine("b) Obtener cubo. \n");
      Console.WriteLine("c) Cálculo de IMC (Índice de Masa Corporal). \n");
      Console.WriteLine("d) Salir. \n");

      letra = Console.ReadLine();


      switch (letra){
        case "a": 
        dividir();
        break;
        case "b":
        cubo();
        break;
        case "c":
        IMC();
        break;
        case "d":
        Environment.Exit(1);
        break;
        default:
        Console.WriteLine("Se ha equivocado de opcion, solo se aceptan de a hasta d");
        break;
      }
    }
  }

  static void dividir(){
    Double num1, num2, div;
    Console.WriteLine("Escriba el dividendo");
    num1 = Double.Parse(Console.ReadLine());
    Console.WriteLine("Escriba el divisor");
    num2 = Double.Parse(Console.ReadLine());

    div = num1/num2;

    Console.WriteLine("El resultado de la division es igual a " + div + "\n");
  }

  static void cubo(){
    Double num, resultado;
    Console.WriteLine("Escriba el numero que se quiere elevar al cubo");
    num = Double.Parse(Console.ReadLine());
    resultado = num * num * num;
    Console.WriteLine(num + " al cubo es " + resultado  + "\n");
  }

  static void IMC(){
    Double indice, peso, altura;
    Console.WriteLine("Escriba su peso en kg");
    peso = Double.Parse(Console.ReadLine());
    Console.WriteLine("Escriba su altura en metros");
    altura = Double.Parse(Console.ReadLine());
    indice = peso / (altura * altura);
    Console.WriteLine("El indice de masa corporal es igual a " + indice  + "\n");
  }
}