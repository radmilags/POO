using System;
class HelloWorld {
    public static void ordernar(ref int x, ref int y, ref int z){
        int[] s = {x, y, z};
        // s[0] = x; s[1] = y; s[2] = z;
        Array.Sort(s);
        x = s[0]; y = s[1]; z = s[2];
    }
  static void Main() 
  {
    int m = 3;
    int n = 2;
    int o = 1;
    
    ordernar(ref m, ref n, ref o);
    
    Console.WriteLine($"{m} {n} {o}");
  }
}
