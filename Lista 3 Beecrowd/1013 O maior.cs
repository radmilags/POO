using System;

class MainClass {
  public static void Main (string[] args) {
            string numeros = Console.ReadLine();
            string[] x = numeros.Split(' ');
            int A = int.Parse(x[0]);
            int B = int.Parse(x[1]);
            int C = int.Parse(x[2]);

          double maiorAB = (A+B+Math.Abs(A-B))/2;
			    double maiorABC = (maiorAB+C+Math.Abs(maiorAB-C))/2;

          Console.WriteLine($"{maiorABC} eh o maior");

  }
}
