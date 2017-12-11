﻿using System.Collections.Generic;
using System.Linq;

namespace ControladorPassagem.Models
{
    public class AccountModel
    {

        private List<Account> listAccounts = new List<Account>();

        public AccountModel()
        {
            listAccounts.Add(new Account { Username = "Gustavo", Password = "123" });
            listAccounts.Add(new Account { Username = "Victor", Password = "123" });
        }

        public bool login(string username, string password)
        {
            return listAccounts.Count(acc => acc.Username.Equals(username) && acc.Password.Equals(password)) > 0;
        }

    }
}