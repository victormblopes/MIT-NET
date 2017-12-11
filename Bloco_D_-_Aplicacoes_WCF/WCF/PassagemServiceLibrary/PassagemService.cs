using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassagemServiceLibrary
{
    public class PassagemService : IPassagemService
    {

        public Passagem criarPassagem(string nome, DateTime data, decimal valor)
        {
            return new Passagem(nome, data, valor);
        }

    }
}
