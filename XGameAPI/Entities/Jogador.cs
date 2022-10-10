using System;
using XGame.Domain.ValueObjects;

namespace XGame.Domain.Entities
{
    public class Jogador
    {
        public Guid Id { get; set; }
        public Nome FirstName { get; set; }
        public string LastName { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
        public EnumSituacaoJogador Status { get; set; }
    }
}
