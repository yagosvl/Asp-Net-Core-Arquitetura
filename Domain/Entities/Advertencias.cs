using System;

namespace Domain.Entities
{
    public class Advertencias
    {
        public int Id { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public int EstagiarioId { get; set; }

        public virtual Estagiario Estagi { get; set; }
    }
}