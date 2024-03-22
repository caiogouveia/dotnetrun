using System;
using CU;
namespace c_sharp_test;

class Program
{
  const person_name = "Joseph";
  static void Main(string[] args)
  {
    Console.WriteLine("Palmeiras tem Mundial ?!");
    var resposta = Console.ReadLine();
    if (resposta == "não" || resposta == "nao" || resposta == "n")
    {
      Console.WriteLine($"correto... mas ... vamos consultar o {person_name}!");
      Console.Write("consultando o Zeh...");
      ConsoleUtility.WriteProgress(0);
      for (var i = 0; i <= 100; ++i)
      {
        ConsoleUtility.WriteProgress(i, true);
        Thread.Sleep(50);
      }
      Console.WriteLine("");
      Console.WriteLine($"{person_mame} diz: Não importa, vc está errado! 'Palmeiras tem Mundial");
    }
    else
    {
      Console.WriteLine($"é ... segundo o {person_mame}, você está errado!");
      ConsoleUtility.WriteProgressBar(0);
      for (var i = 0; i <= 100; ++i)
      {
        ConsoleUtility.WriteProgressBar(i, true);
        Thread.Sleep(50);
      }
      Console.WriteLine();
      Console.WriteLine($"{person_name} diz: Não importa, vc está errado! 'Palmeiras NÃO tem Mundial");
    }
  }
}