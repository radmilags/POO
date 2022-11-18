using System;
class HelloWorld {
  static void Main() 
  {
    string[] s = Console.ReadLine().Split();
    string[] m = Console.ReadLine().Split();
    int x = 0;
    for(int i = 0; i < 6; i++){
        for(int j = 0; j < 6; j++){
            if(s[i] == m[j]) x++;
        }
    }
    if(x < 3) Console.WriteLine("azar");
    else if(x == 3) Console.WriteLine("terno");
    else if(x == 4) Console.WriteLine("quadra");
    else if(x == 5) Console.WriteLine("quina");
    else Console.WriteLine("sena");
  }
}
