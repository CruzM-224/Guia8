using System;

class MainClass {
  public static void Main (string[] args) {
    Double r, angulo, x, y;
    Console.WriteLine("Escriba el radio");
    r = Double.Parse(Console.ReadLine());
    Console.WriteLine("Escriba el angulo");
    angulo = Double.Parse(Console.ReadLine());

    x = rcos(r, angulo);

    y = rsen(r, angulo);

    Console.WriteLine("x = " + x + "; y = " + y);
    Console.WriteLine("(" + x + ", " + y);
  }
  static Double rcos(Double r, Double angulo){
    Double x;
    x = r * Math.Cos(angulo);
    return x;
  }
  static Double rsen(Double r, Double angulo){
    Double y;
    y = r * Math.Sin(angulo);
    return y;
  }
}