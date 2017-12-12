using System.Runtime.Serialization;

namespace VendedorPassagem.Exception
{
    [DataContract]
    public class EmptyQueueException
    {

        [DataMember]
        public string Mensagem { get; set; }

        public EmptyQueueException(string msg)
        {
            Mensagem = msg;
        }

    }
}