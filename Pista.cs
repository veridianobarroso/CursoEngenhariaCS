using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoEngenhariaCS
{
    public class Pista
    {
        public int Id { get; set; }
        public string? Clima { get; set; }
    }

    public class Treino: Pista{
        public int barreiras { get; set; }
    }
}