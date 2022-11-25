using System;
class HelloWorld {
  static void Main() 
  {
    string s;
    while(!string.IsNullOrEmpty(s = Console.ReadLine())){
        string[] s1 = s.Split();
        double D = double.Parse(s1[0]);
        double VF = double.Parse(s1[1]);
        double VG = double.Parse(s1[2]);
        double dist = Math.Sqrt(144 + D * D);
        double TF = 12 / VF;
        double TG = dist / VG;
		if(TG <= TF) Console.WriteLine("S");
		else Console.WriteLine("N");
    }
  }
}
