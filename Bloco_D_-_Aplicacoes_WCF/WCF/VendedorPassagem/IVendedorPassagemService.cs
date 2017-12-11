using System.ServiceModel;
using VendedorPassagem.ControladorPassagemService;
using VendedorPassagem.Exception;

namespace VendedorPassagem
{
    [ServiceContract]
    public interface IVendedorPassagemService
    {
        [OperationContract]
        [FaultContract(typeof(EmptyQueueException))]
        Passagem ComprarPassagem();

        [OperationContract]
        Passagem[] ListarPassagens();
    }
}
