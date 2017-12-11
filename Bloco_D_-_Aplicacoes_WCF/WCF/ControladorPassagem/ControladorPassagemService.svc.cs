using System;
using System.Linq;
using ControladorPassagem.PassagemService;
using System.Collections.Concurrent;

namespace ControladorPassagem
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ControladorPassagemService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ControladorPassagemService.svc or ControladorPassagemService.svc.cs at the Solution Explorer and start debugging.
    public class ControladorPassagemService : IControladorPassagemService
    {

        private static ConcurrentDictionary<Guid, Passagem> passagens = new ConcurrentDictionary<Guid, Passagem>();

        public bool AddPassagem(string destino, DateTime data, decimal valor)
        {
            Passagem passagem;

            using (var cli = new PassagemServiceClient())
            {
                cli.Open();
                passagem = cli.criarPassagem(destino, data, valor);
                cli.Close();
            }

            if (passagem != null)
                return passagens.TryAdd(passagem.Id, passagem);

            return false;
        }

        public Passagem[] ListarPassagens()
        {
            return passagens.Values.ToArray<Passagem>();
        }

        public bool venderPassagem(Guid id)
        {
            Passagem passagem;
            passagem = passagens[id];
            passagem.Disponivel = false;

            if (passagem != null)
                return passagens.TryUpdate(id, passagem, passagem);

            return false;
        }
    }
}
