using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Estagiario
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Advertencias> Mancadas { get; set; }
    }
}
