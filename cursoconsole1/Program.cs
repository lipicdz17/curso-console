using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoconsole1
{
    class Program
    {
        static void Main(string[] args)
        {
           

       int opcao, operacao;
       string cliente = "", produto = "";

       do
       {
       Console.Clear();
       Console.WriteLine("1 - cliente");
       Console.WriteLine("2 - produto");
       Console.WriteLine("3 - sair");
       opcao = Convert.ToInt32(Console.ReadLine());

       Console.ReadKey();

       switch (opcao)
       {

           case 1:
               Console.WriteLine("1 - cadastrar cliente:");
               Console.WriteLine("2 - consultar cliente:");
               break;
           case 2:
               Console.WriteLine("1 - cadastrar produto:");
               Console.WriteLine("2 - consultar produto");
               break;
           case 3:
               Console.WriteLine("saindo..");
               break;
           default:
               Console.WriteLine("opcao invalida");
               break;
       }
       if ((opcao.Equals(1)))
       {
           operacao = Convert.ToInt32(Console.ReadLine());
           if (operacao.Equals(1))
           {
               Console.WriteLine("digite nome: ");
               cliente = Console.ReadLine();

           }
           else if ((operacao.Equals(2)))
           {
               Console.WriteLine("nome do cliente: " + cliente);
               Console.ReadKey();
           }
           else
           {
               Console.WriteLine("opcao invalida!");
           }
       }
       else if ((opcao.Equals(2)))
       {
           operacao = Convert.ToInt32(Console.ReadLine());
           if (operacao.Equals(1))
           {
               Console.WriteLine("informe o nome");
               produto = Console.ReadLine();

           }
           else if ((operacao.Equals(2)))
           {
               Console.WriteLine("descricao: " + produto);
               Console.ReadKey();
           }
           else
           {
               Console.WriteLine("opcao invalida");
           }
       }
   } while (opcao != 3);

        }
    }
}
