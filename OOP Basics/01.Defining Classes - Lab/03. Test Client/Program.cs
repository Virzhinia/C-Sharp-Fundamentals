using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var accounts = new Dictionary<int, BankAccount>();
        string command;

        while ((command=Console.ReadLine()) != "End")
        {
            var splitCommand = command.Split();
            var accountId = int.Parse(splitCommand[1]);
            switch (splitCommand[0])
            {
                case "Create": if(accounts.ContainsKey(accountId))
                    {
                        Console.WriteLine("Account already exists");
                    }
                else
                    {
                        var account = new BankAccount();
                        account.ID = accountId;
                        accounts.Add(accountId, account);
                    }
                    break;
                case "Deposit":
                    if(ValidateAccountExits(accountId,accounts))
                    {
                        accounts[accountId].Deposit(int.Parse(splitCommand[2]));
                    }
                    break;
                case "Withdraw":
                    if(ValidateAccountExits(accountId,accounts))
                    {
                        accounts[accountId].Withdraw(int.Parse(splitCommand[2]));
                    }
                    break;
                case "Print":
                    if (ValidateAccountExits(accountId, accounts))
                    {
                        Console.WriteLine(accounts[accountId]);
                    }
                    break;
                default:
                    break;
            }
        }
    }
    static bool ValidateAccountExits(int accountId, Dictionary<int,BankAccount> accounts)
    {
        if (accounts.ContainsKey(accountId))
        {
            return true;
        }
        else
        {
            Console.WriteLine("Account does not exist");
            return false;
        }
    }
}