using System;
class HelloWorld {
    public static int MMC(int a, int b){
        int i = 2; int x = 1;
        while(a != 1 || b !=1){
            if(a%i != 0 && b%i != 0) i++;
            else 
            {
                if(a%i == 0) a/=i;
                if(b%i == 0) b/=i;
                x*=i;
            }
        }
        return x;
    }
  static void Main() 
  {
    int a = 12; int b = 8;
    
    Console.WriteLine(MMC(a, b));
  }
}
