/******************************************************************************

2. Uma Disciplina
A classe deve ter atributos para armazenar o nome da disciplina e as notas dos quatros bimestres e da prova final.
Os métodos da classe devem permitir calcular a média parcial (com as notas bimestrais) e a média final (com todas
as notas, caso o aluno tenha ficado em prova final). Considere como média de aprovação o valor 60, notas de 0 a
100, média parcial ponderada com pesos 2, 2, 3 e 3 e média final como a média aritmética da média parcial com a
nota da prova final, caso o aluno não seja aprovado por média.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Disciplina{
    // private int n1,n2,n3,n4,nf;
    private int mediaP, nf;
    public Disciplina(int n1, int n2, int n3, int n4, int nf){
        // this.n1 = n1; this.n2 = n2; this.n3 = n3; this.n4 = n4; this.nf = nf;
        this.nf = nf;
        this.mediaP = (n1*2+n2*2+n3*3+n4*3)/10;
    }
    public int Nota(){
        if(mediaP < 60) return (mediaP+nf)/2;
        return mediaP;
    }
}
class HelloWorld {
  static void Main() {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    int e = int.Parse(Console.ReadLine());
    Disciplina disc = new Disciplina(a, b, c, d, e);
    Console.WriteLine(disc.Nota());
  }
}
