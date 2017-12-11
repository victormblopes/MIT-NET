using ControladorPassagem.PassagemService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ControladorPassagem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IControladorPassagemService" in both code and config file together.
    [ServiceContract]
    public interface IControladorPassagemService
    {
        [OperationContract]
        bool AddPassagem(string destino, DateTime data, decimal valor);

        [OperationContract]
        Passagem[] ListarPassagens();

        [OperationContract]
        bool venderPassagem(Guid id);
    }
}
