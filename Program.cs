using CursoEngenhariaCS;
namespace System;

public class Program {
    // svm
    public static void Main()
    {
        // Conta conta = new Conta();
        // conta.Deposita(50);
        // System.Console.WriteLine($"Saldo: {conta.Saldo}");
        // conta.Saca(10);
        // System.Console.WriteLine($"Saldo: {conta.Saldo}");
        
        Especial especial = new Especial();
        especial.Deposita(100);
        System.Console.WriteLine($"Saldo: {especial.Saldo}");
        especial.Saca(5);
        System.Console.WriteLine($"Saldo: {especial.Saldo}");
        

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




    }

  
    
}
