using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoEngenhariaCS
{
    public class Carro
    {   
        // prop
        public int Id { get; set; }
        public string? Nome { get; set; }
        public double VeloxMax  { get; set; }
        public void Alterar(double a){
            VeloxMax = a;
        }
    }
}