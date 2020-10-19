// ©Arthurdw | GO-AO
using System;
using System.Collections.Generic;
using System.Linq;

namespace LoggingIn
{
    public enum AccountPermission
    {
        Admin,
        Member
    }

    public class AccountHandler
    {
        public HashHandler Hasher { get; }
        public FileHandler File { get; }
        public List<Account> Accounts { get; private set; }
        public List<string> Hashes { get; }

        public AccountHandler(HashHandler hashHandler, FileHandler fileHandler)
        {
            Hasher = hashHandler;
            File = fileHandler;
            Accounts = InitAccounts();
            Hashes = InitHashes();
        }

        public void ReloadAccountData() =>
            Accounts = InitAccounts();

        public List<string[]> GetAccountData() => File.GetData().Skip(1).ToList();

        private List<Account> InitAccounts()
        {
            List<string[]> data = GetAccountData();
            List<Account> accountsData = new List<Account>();
            foreach (string[] row in data)
            {
                AccountPermission permission = int.Parse(row[4]) == (int)AccountPermission.Admin ? AccountPermission.Admin : AccountPermission.Member;
                Account account = new Account(row[0], row[1], row[2], DateTime.Parse(row[3]), permission);
                accountsData.Add(account);
            }

            Console.WriteLine(accountsData.Count);

            return accountsData;
        }

        private List<string> InitHashes()
        {
            List<string> hashesData = new List<string>();
            foreach (Account account in Accounts) hashesData.Add(account.PasswordHashed);
            return hashesData;
        }

        public bool IsValidPass() => Hashes.Contains(Hasher.GetHashSha512());

        public Account GetAccount()
        {
            foreach (Account account in Accounts)
                if (account.PasswordHashed == Hasher.GetHashSha512())
                    return account;

            return null;
        }
    }

    public class Account
    {
        public string UserName { get; }
        public string Password { get; }
        public string PasswordHashed { get; }
        public DateTime LastUpdate { get; }
        public AccountPermission Permission { get; }

        public Account(string username, string password, string passwordHashed, DateTime lastUpdate, AccountPermission permission)
        {
            UserName = username;
            Password = password;
            PasswordHashed = passwordHashed;
            LastUpdate = lastUpdate;
            Permission = permission;
        }
    }
}