using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CursoEngenhariaCS
{
    public class ProgramaParalelo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione ENTER para iniciar");
            Console.ReadLine();

            // Invocar os métodos que vamos executar
            Parallel.Invoke(
               new Action(exibirDias),
               new Action(Aleatorios),
               new Action(exibirMeses),
               new Action(exibirCidades)   
            );

            // Aguardar a continuação do programa
            Console.WriteLine("\nO método Main foi encerrado. Tecle Enter");
            Console.ReadLine();
        }

        static void exibirDias()
        {
            string[] diasArray = { "Segunda", "Terça", "Quarta","Quinta", "Sexta", "Sábado", "Domingo" };
            foreach (string dia in diasArray)
            {
               Console.WriteLine("Dia da semana: " + dia);
               Thread.Sleep(2000);
            }
        }
       
        static void exibirMeses()
        {
            string[] messArray = { "Jan", "Fev", "Mar", "Abr","Mai", "Jun", "Jul",
                                   "Ago", "Set", "Out", "Nov", "Dec" };

            foreach (string mes in messArray)
            {
               Console.WriteLine("Mês : {0}", mes);
                Thread.Sleep(2000);
            }
        }
       
        static void exibirCidades()
        {
            string[] cidadesArray = { "Londres", "New York", "Paris", "Tóquio","Sidney" };
            foreach (string cidade in cidadesArray)
            {
               Console.WriteLine("Cidade : {0}", cidade);
                Thread.Sleep(2000);
            }
        }
        static void Aleatorios()
        {
            Random randNum = new Random();

            for (int i = 0; i <= 10; i++)
            {
            System.Console.WriteLine("Num Aleatorio : "+randNum.Next(100));
            Thread.Sleep(2000);
            }
        }
    }
}