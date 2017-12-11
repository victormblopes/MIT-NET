using PassagensConsoleApp.ControladorPassagemService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;

namespace PassagensConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Passagem[] passagens;

            //Console.WriteLine("Autenticando usuário...");
            //using (var client = new AuthenticationServiceClient())
            //{
            //    client.Open();
            //    client.ClientCredentials.ServiceCertificate.Authentication.CertificateValidationMode = X509CertificateValidationMode.None;
            //    client.ClientCredentials.UserName.UserName = "Victor";
            //    client.ClientCredentials.UserName.Password = "123";
            //    Console.WriteLine(client.autenticar());
            //    Console.ReadLine();
            //}

            // Cria 200 passagens
            Console.WriteLine("Criando passagens...");
            using (var client = new ControladorPassagemServiceClient())
            {
                client.Open();
                for (int i = 0; i < 10; i++)
                {
                    client.AddPassagem("Miami", DateTime.Now, 2000);
                    client.AddPassagem("Las Vegas", DateTime.Now, 2500);
                    client.AddPassagem("Paris", DateTime.Now, 3500);
                    client.AddPassagem("Russia", DateTime.Now, 3400);
                    client.AddPassagem("Rio de Janeiro", DateTime.Now, 1500);
                    client.AddPassagem("São Paulo", DateTime.Now, 1800);
                    client.AddPassagem("Porto Alegre", DateTime.Now, 1900);
                    client.AddPassagem("Orlando", DateTime.Now, 2300);
                    client.AddPassagem("Jamaica", DateTime.Now, 2000);
                    client.AddPassagem("Costa Rica", DateTime.Now, 2100);
                    client.AddPassagem("Suiça", DateTime.Now, 2000);
                    client.AddPassagem("Africa", DateTime.Now, 2500);
                    client.AddPassagem("Cuba", DateTime.Now, 1200);
                    client.AddPassagem("Venezuela", DateTime.Now, 1100);
                    client.AddPassagem("Argentina", DateTime.Now, 10);
                    client.AddPassagem("Uruguai", DateTime.Now, 1800);
                    client.AddPassagem("Paraguai", DateTime.Now, 1);
                    client.AddPassagem("Japão", DateTime.Now, 4000);
                    client.AddPassagem("China", DateTime.Now, 3800);
                    client.AddPassagem("Australia", DateTime.Now, 3600);
                }
                client.Close();
            }
            Console.WriteLine("Passagens criadas!");
            Console.ReadLine();

            // Lista as passagens criadas
            using (var client = new ControladorPassagemServiceClient())
            {
                client.Open();
                passagens = client.ListarPassagens();
                client.Close();
            }
            Console.WriteLine("Listando passagens criadas...");
            foreach (var passagem in passagens)
            {
                Console.WriteLine(passagem.Destino + " - " + passagem.Data + " - " + passagem.Valor + " - " + passagem.Disponivel);
            }
            Console.WriteLine("Fim da lista!");
            Console.ReadLine();

        }
    }
}
