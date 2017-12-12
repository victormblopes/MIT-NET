using System;
using System.Threading.Tasks;
using ClienteConsoleApp.VendedorPassagemService;
using System.ServiceModel;

namespace ClienteConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var cli = new VendedorPassagemServiceClient())
            {
                cli.Open();
                cli.ListarPassagens();
                cli.Close();
            }

            Console.WriteLine("Pressione ENTER para comecar a consumir as passagens...");
            Console.ReadLine();

            Console.WriteLine("Consumindo passagens...");

            const int qtdClientes = 5;

            Task<bool>[] clientes = new Task<bool>[qtdClientes];

            for (int i = 0; i < qtdClientes; i++)
                clientes[i] = Task.Run(() => TaskComprarPassagem() );
            Task.WaitAll(clientes);

            int countQtdPassagensCompradas = 0;
            foreach (var cliente in clientes) {
                if (cliente.Result == true)
                    countQtdPassagensCompradas++;
            }

            Console.WriteLine($"Total de passagens vendidas: {countQtdPassagensCompradas}" );
            Console.WriteLine($"Total de Clientes que tentaram comprar passagem: {clientes.Length}");

            Console.ReadLine();
                    
        }

        static bool TaskComprarPassagem()
        {
            Passagem passagem = null;
            using (var cli = new VendedorPassagemServiceClient())
            {
                cli.Open();
                try
                {
                    passagem = cli.ComprarPassagem();
                }
                catch(FaultException ex)
                {
                    Console.WriteLine(ex.Message);
                    passagem = null;
                }
                cli.Close();
            }

            if (passagem == null)
                return false;

            return true;
        }
    }
}
