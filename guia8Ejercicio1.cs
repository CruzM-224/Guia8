using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Calculo de la edad");
    calculoEdad();
  }
  static void calculoEdad(){
    int edad, nacimiento;
    Console.WriteLine("Año de nacimiento: ");
    nacimiento = int.Parse(Console.ReadLine());
    edad = 2021 - nacimiento;
    Console.WriteLine("La edad es igual a " + edad + " años");
  }
}