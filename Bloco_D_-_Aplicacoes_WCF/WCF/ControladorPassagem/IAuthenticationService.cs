using System.ServiceModel;

namespace ControladorPassagem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAuthenticationService" in both code and config file together.
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        string autenticar();
    }
}
