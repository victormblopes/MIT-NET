using System;
using System.Runtime.Serialization;

namespace PassagemServiceLibrary
{
    [DataContract]
    public class Passagem
    {

        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Destino { get; set; }
        [DataMember]
        public DateTime Data { get; set; }
        [DataMember]
        public Decimal Valor { get; set; }
        [DataMember]
        public bool Disponivel { get; set; }

        public Passagem(string destino, DateTime data, decimal valor)
        {
            Id = Guid.NewGuid();
            Destino = destino;
            Data = data;
            Valor = valor;
            Disponivel = true;
        }

    }
}
