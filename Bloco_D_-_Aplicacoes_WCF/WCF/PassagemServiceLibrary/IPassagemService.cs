using System;
using System.ServiceModel;

namespace PassagemServiceLibrary
{
    [ServiceContract]
    public interface IPassagemService
    {

        [OperationContract]
        Passagem criarPassagem(string destino, DateTime data, Decimal valor);

    }
}
