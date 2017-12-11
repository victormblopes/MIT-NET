using ControladorPassagem.Models;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace ControladorPassagem.Authentication
{
    public class CustomValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            AccountModel am = new AccountModel();
            if (am.login(userName, password))
                return;
            throw new SecurityTokenException("Conta inválida!");
        }
    }
}