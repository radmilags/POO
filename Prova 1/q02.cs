using System;
class PecaDomino{
    private int l1;
    private int l2;
    
    public PecaDomino(int l1, int l2){
        this.SetValidar1(l1);
        this.SetValidar2(l2);
    }
    public void SetValidar1(int l1){
        if(l1 > 0 && l1 < 7) this.l1 = l1;
    }
    public void SetValidar2(int l2){
        if(l2 > 0 && l2 < 7) this.l2 = l2;
    }
    public int Get1(){return this.l1;}
    public int Get2(){return this.l2;}

    public bool Combinar(PecaDomino pd){
        if(this.l1 == pd.l1 || this.l1 == pd.l2 || this.l2 == pd.l1 || this.l2 == pd.l2) return true;
        else return false;
    }
    public override string ToString(){
        return $"LADO 1 = {this.l1} - LADO 2 = {thiss.l2};
    }
}

class Program {
  public static void Main (string[] args) {
    PecaDomino[] p = new PecaDomino[2];
    for(int i = 0; i < 2; i++){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        p[i] = new PecaDomino(a, b);
    }
    
    Console.WriteLine(p[0].Combinar(p[1]));

  }
}
