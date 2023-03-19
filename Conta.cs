using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoEngenhariaCS
{
    public class Conta
    {
        public double Saldo { get; protected set; }

        public void Deposita(double valor){

            this.Saldo += valor;
            
            System.Console.WriteLine($"Depositou: {this.Saldo}");
            
        }
        public virtual void Saca(double valor){
            this.Saldo = this.Saldo - valor - 1;
            this.Saldo = Math.Round(this.Saldo, 2);
            System.Console.WriteLine($"Sacou: {valor} -> Taxa: 1,00 -> Saldo: {this.Saldo}");
        }
        public virtual void Saca(double valor, double taxa){
            
            this.Saldo = this.Saldo - valor - (valor * taxa)/100;
            this.Saldo = Math.Round(this.Saldo, 2);
            System.Console.WriteLine($"Sacou: {valor} -> Taxa: {taxa}% -> Saldo: {this.Saldo}");
        }
    }
    public class Especial : Conta{
        public override void Saca(double valor)
        {
             this.Saldo = this.Saldo - valor -3;
        }

    }
}