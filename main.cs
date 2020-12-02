using System;
using System.Collections.Generic;

class MainClass {

  static List<Empregado> empregados = new List<Empregado>();
  static Menu menu = new Menu();

  public static void Main () {

    string validador = "s";
    int option = 0;

    while(validador == "s"){
      try {
        menu.getMenu();
        option = int.Parse(Console.ReadLine());
      } catch (FormatException){
        Console.WriteLine("Favor digitar um valor inteiro!");
        validador = "s";
      }

      switch(option){
        case 1:
          cadColab();
          break;
        case 2:
          ajustaSalario();
          break;
        case 3:
          ajustaNome();
          break;
        case 4:
          ajustaSobreNome();
          break;
        case 5:
          listaEmpregados();
          break;
        case 6:
          ajustaSalarioGeral();
          break;
        default:
          Console.WriteLine("Opção inválida!");
          break;
      }
      Console.WriteLine("Digite 's' para continuar no sistema ou qualquer outra tecla para sair!");
      validador = Console.ReadLine();
    }


    Console.WriteLine(empregados[0].getNome());
  }

  public static void ajustaNome(){
    if(validaTamanho() == false){
      return;
    }
    listaEmpregados();
    Console.WriteLine("Digite o número do cadastro do colaborador:");
    int indice = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o novo nome do colaborador:");
    string nome = Console.ReadLine();
    empregados[indice].setNome(nome);
  }

  public static void ajustaSobreNome(){
    if(validaTamanho() == false){
      return;
    }
    listaEmpregados();
    Console.WriteLine("Digite o número do  cadastro do colaborador:");
    int indice = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o novo sobrenome do colaborador:");
    string sobrenome = Console.ReadLine();
    empregados[indice].setSobreNome(sobrenome);

  }

  public static void ajustaSalario(){
    if(validaTamanho() == false){
      return;
    }
    listaEmpregados();
    Console.WriteLine("Digite o número de cadastro do colaborador:");
    int indice = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o novo salário do colaborador:");
    double salario = double.Parse(Console.ReadLine());
    empregados[indice].setSalario(salario);
  }

  public static bool validaTamanho(){
    if (empregados.Count <= 0){
      Console.WriteLine("Favor cadastrar um colaborador!");
      return false;
    } else {
      return true;
    }
  }

  public static void ajustaSalarioGeral(){
    if(validaTamanho() == false){
      return;
    }

    Console.WriteLine("Digite o percentual do ajuste:");
    double percentual = double.Parse(Console.ReadLine());
    for(int i = 0;i < empregados.Count;i++){
      percentual = (percentual / 100) + 1;
      double getsalario = empregados[i].getSalario();
      getsalario = getsalario * percentual;
      empregados[i].setSalario(getsalario);
    }
  }

  public static void cadColab(){
    Console.WriteLine("Digite o nome do colaborador!");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o sobrenome do colaborador!");
    string sobrenome = Console.ReadLine();
    Console.WriteLine("Digite o salário do colaborador!");
    double salario = double.Parse(Console.ReadLine());
    Empregado empregado = new Empregado(nome,sobrenome,salario);
    empregados.Add(empregado);
  }

  public static void listaEmpregados(){
    if(validaTamanho() == false){
      return;
    }
    for(int i = 0;i < empregados.Count;i++){
      Console.WriteLine("Número de cadastro: {0}",i);
      Console.WriteLine("Nome: {0}",empregados[i].getNome());
      Console.WriteLine("Sobrenome: {0}",empregados[i].getSobreNome());
      Console.WriteLine("Salário: {0}",empregados[i].getSalario());
      Console.WriteLine("---------------------------------------");
    }
  }
}