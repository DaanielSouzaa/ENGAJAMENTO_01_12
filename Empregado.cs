using System;

class Empregado {
  
  private string nome;
  private string sobrenome;
  private double salario;
  
  public Empregado(string nome,string sobrenome,double salario)
  {
    setNome(nome);
    setSobreNome(sobrenome);
    setSalario(salario);
  }

  public string getNome(){
    return this.nome;
  }

  public void setNome(string nome){
    this.nome=nome;
  }

  public string getSobreNome(){
    return this.sobrenome;
  }

  public void setSobreNome(string sobrenome){
    this.sobrenome=sobrenome;
  }

  public double getSalario(){
    return this.salario;
  }

  public void setSalario(double salario){

    if (salario < 0){
      try {
        throw new ArithmeticException();
      }
      catch (ArithmeticException){
        Console.WriteLine("Erro, salário é menor do que 0");
      }
    }

    this.salario=salario;
  }
  
}