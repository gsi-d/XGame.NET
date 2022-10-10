using System;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public Nome Name { get; set; }
        public string Descricao { get; set; }
        public string Produtora { get; set; }
        public string Distribuidora { get; set; }
        public string Genero { get; set; }
        public string Site { get; set; }
    }
}
