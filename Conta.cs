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
        }
        public virtual void Saca(double valor){
            this.Saldo = this.Saldo - valor -1;
        }
    }
    public class Especial : Conta{
        public override void Saca(double valor)
        {
             this.Saldo = this.Saldo - valor -3;
        }
    }
}