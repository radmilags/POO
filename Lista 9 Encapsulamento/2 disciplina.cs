/******************************************************************************

2. Uma Disciplina
Escrever a classe Disciplina de acordo com o diagrama UML apresentado abaixo. A classe deve ter atributos para
armazenar o nome da disciplina e as notas dos quatros bimestres e da prova final. Os métodos da classe devem
permitir calcular a média parcial (com as notas bimestrais) e a média final (com todas as notas, caso o aluno tenha
ficado em prova final), além dos métodos de acesso para definir e recuperar o nome e as notas da disciplina.
Considere como média de aprovação o valor 60, notas de 0 a 100, média parcial ponderada com pesos 2, 2, 3 e 3
e média final como a média aritmética da média parcial com a nota da prova final, caso o aluno não seja aprovado
por média.
Escrever um programa para testar a classe.

*******************************************************************************/
using System;
class Disciplina{
    private string nome;
    private int nota1, nota2, nota3, nota4, notaf, media;
    public void SetNome(string nome){
        if(nome !="") this.nome = nome;
    }
    public void SetNotas(int n1, int n2, int n3, int n4, int nf){
        if(n1 >= 0 && n2 >= 0 && n3 >= 0 && n4 >= 0 && nf >= 0){
            nota1 = n1; nota2 = n2; nota3 = n3; nota4 = n4; notaf = nf;
        }
        else Console.WriteLine("Você digitou uma nota invalida");
    }
    public string GetNome(){ return nome;}
    public int GetNota1(){return nota1;}
    public int GetNota2(){return nota2;}
    public int GetNota3(){return nota3;}
    public int GetNota4(){return nota4;}
    public int GetNotaFinal(){return notaf;}
    
    public void CalcMediaParcial(){
        media = (nota1*2+nota2*2+nota3*3+nota4*3)/10;
    }
    
    public int CalcMediaFinal(){
        if(media >= 60) return media;
        return (media+notaf)/2;
    }
    
}
class HelloWorld {
  static void Main() 
  {
    Disciplina d = new Disciplina();
    d.SetNotas(50, 100, 60, 80, 100);
    Console.WriteLine(d.CalcMediaFinal());
  }
}
