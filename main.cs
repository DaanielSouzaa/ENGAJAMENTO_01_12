using System;
using System.Collections.Generic;

class MainClass {

  public static void Main (string[] args) {
    List<Empregado> empregados = new List<Empregado>();
    Menu menu = new Menu();

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
          Console.WriteLine("Digite o nome do colaborador!");
          string nome = Console.ReadLine();
          Console.WriteLine("Digite o sobrenome do colaborador!");
          string sobrenome = Console.ReadLine();
          Console.WriteLine("Digite o salário do colaborador!");
          double salario = double.Parse(Console.ReadLine());
          Empregado empregado = new Empregado(nome,sobrenome,salario);
          empregados.Add(empregado);
          break;
        case 2:
          Console.WriteLine("Digite o percentual do ajuste:");
          double percentual = double.Parse(Console.ReadLine());
          for(int i = 0;i < empregados.Count;i++){
            if (empregados.Count <= 0){
              Console.WriteLine("Favor cadastrar um colaborador!");
              break;
            }
            percentual = (percentual / 100) + 1;
            double salario = empregados[i].getSalario();
            salario = salario * percentual;
            empregados[i].setSalario(salario);
          }
          break;
      }

      Console.WriteLine("Digite 's' para continuar no sistema ou qualquer outra tecla para sair!");
      validador = Console.ReadLine();
    }


    Console.WriteLine(empregados[0].getNome());
  }
}