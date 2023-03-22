using CursoEngenhariaCS;
using CursoEngenhariaCS.files;
using CursoEngenhariaCS.interfaces;

namespace System;

public class Program {
     //svm
     static void Main()
     {
         System.Console.WriteLine("Oi isso é um teste.");
     }
    
    //  Conta conta = new Conta();
    //  conta.Deposita(50.00);
    //  conta.Saca(10.90 , 2);
    //  conta.Saca(7.50);

    //Especial especial = new Especial();
    //especial.Deposita(100);
    //System.Console.WriteLine($"Saldo: {especial.Saldo}");
    //especial.Saca(5);
    //System.Console.WriteLine($"Saldo: {especial.Saldo}");
    
    // INTERFACES

    //  Calculadora calc = new Calculadora();
    //  System.Console.WriteLine("Soma1 -> "+calc.Somar(10,5));
    //  System.Console.WriteLine("Soma2 -> "+calc.Somar(10, 5, 3));
     
    // // A palavra-chave var instrui o compilador para deduzir
    // // o tipo da variável da expressão no lado direito da instrução de inicialização.
    // var caminho = "C:\\Teste123";

    // // // Definição de caminhos para trabalharmos com arquivo
    // // // Operações com arquivos utilizando o nosso FileHelper
    //  FileHelper helper = new FileHelper(caminho);

    // helper.ListarDiretorios(caminho);
    // helper.ListarArquivosDiretorios(caminho);
    
    // var caminhoPathCombine = Path.Combine(caminho, "Teste de Pasta");
    
    // //helper.CriarDiretorio(caminhoPathCombine);
    // //helper.ApagarDiretorio(caminhoPathCombine, true);

    // var caminhoArquivo = Path.Combine(caminho, "arquivo-teste.txt");
    // helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");

    // // Linhas para serem escritas no arquivo
    // var listaString = new List<string> { "Linha 1t", "Linha 2x", "Linha 3a" };
    //  var caminhoArquivo2 = Path.Combine(caminho, "arquivo-teste-stream2.txt");
    // helper.CriarArquivoTextoStream(caminhoArquivo2, listaString);

    //  var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };
    //  helper.AdicionarTextoStream(caminhoArquivo2, listaStringContinuacao);
    
    //  var caminhoArquivoLeitura = Path.Combine(caminho, "arquivo-teste-stream2.txt");
    //  helper.LerArquivoStream(caminhoArquivoLeitura);

    // helper.DeletarArquivo(caminhoArquivoLeitura);

    // // FIM MANIPULAÇÃO DE ARQUIVOS 

    // Pista pista = new Pista();
    // pista.Id = 1;
    // pista.Clima = "Chuva";


    // Treino treino = new Treino();
    // treino.Id = 2;
    // treino.Clima = "Sol";
    // treino.barreiras = 4;

    // Carro carro = new Carro();
    // carro.Id = 1;
    // carro.Nome = "Ferrari";
    // carro.VeloxMax = 300;
    // System.Console.WriteLine($"{carro.VeloxMax}" );
    // carro.Alterar(120);
    // System.Console.WriteLine($" nova {carro.VeloxMax}" );
        

//         string? nome;
//         int Idade;
//         double Altura, resultado,Peso;

//         double IMC (int idade, double altura, double peso) {
//             double calculo;
//             calculo = peso / (altura * altura); 
//             return calculo;
//         }

        
//         System.Console.WriteLine("Digite seu nome: ");
//         nome = Console.ReadLine();
//         System.Console.WriteLine("Digite sua idade: ");    
//         Idade = Convert.ToInt32(Console.ReadLine());
        
//         System.Console.WriteLine("Digite sua altura: ");    
//         Altura = Convert.ToDouble(Console.ReadLine());

//         System.Console.WriteLine("Digite seu peso: ");    
//         Peso = Convert.ToDouble(Console.ReadLine());

//         resultado = IMC(Idade, Altura, Peso);
// System.Console.WriteLine("resultado -> " + resultado);
// System.Console.WriteLine($"seu nome {nome} e resultado -> {resultado}");       
//         if(resultado <= 30){
//             System.Console.WriteLine("normal");
//         }else if( resultado >30){
//             System.Console.WriteLine("obesidade");
//         }


        

//        int numero;
//        numero = 7;
//        int retorno;
       
//         if(numero == 10)
//         { 
//           retorno = Alterar(numero);   
//         }
//         else{  retorno = numero; }
//         System.Console.WriteLine(retorno);

//         while(numero < 10)
//         {
// System.Console.WriteLine("while" + numero);
//             numero++;
//         }
//         for(int x = 0; x < 10; x++){
//             System.Console.WriteLine("for" + x);
//         }

//         int Alterar(int a){
//                 return a+1;
//             }

//         //void Alterar(int a){
//         //    System.Console.WriteLine(a + 1);
//         //}
//     string [] nomes = new string[]{"oi","oi2", "oi3"}; 
//     foreach (string nome in nomes)
//     {
//         System.Console.WriteLine(nome);
//         if(nome == "oi2"){ break; }
//     }
//     System.Console.WriteLine(nomes[0]);
//     int var = 3;
//     switch (var)
//     {
//         case 3:
//             System.Console.WriteLine("3");
//             break;
//         default:
//             System.Console.WriteLine("nada");
//             break;

// }




    //}

  
    
}
