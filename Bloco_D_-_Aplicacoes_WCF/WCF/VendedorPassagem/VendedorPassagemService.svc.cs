using System.Collections.Concurrent;
using System.Linq;
using System.ServiceModel;
using VendedorPassagem.ControladorPassagemService;
using VendedorPassagem.Exception;

namespace VendedorPassagem
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults = true)]
    public class VendedorPassagemService : IVendedorPassagemService
    {

        // Representa uma coleção FIFO: First-in, First-Out (FILA)
        private static ConcurrentQueue<Passagem> passagensQueue = new ConcurrentQueue<Passagem>();

        // Realiza a compra de passagens disponíveis na fila.
        // Caso não exista passagem disponível na fila, uma exceção é lançada.
        public Passagem ComprarPassagem()
        {
            Passagem passagem = null;
            passagensQueue.TryDequeue(out passagem);
            if (passagem == null && passagensQueue.Count == 0)
            {
                throw new FaultException<EmptyQueueException>(new EmptyQueueException("Fila vazia"));
            }
            return passagem;
        }

        //Lista as passagens disponíveis no array e inseri na fila
        public Passagem[] ListarPassagens()
        {
            Passagem[] passagens = null;
            using (var cli = new ControladorPassagemServiceClient())
            {
                cli.Open();
                passagens = cli.ListarPassagens().Where(c => c.Disponivel).ToArray();
                cli.Close();
            }
            foreach (var passagem in passagens)
            {
                passagensQueue.Enqueue(passagem);
            }
            return passagens;
        }
    }
}
