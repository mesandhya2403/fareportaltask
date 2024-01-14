using System.Data;
using System.Transactions;

namespace Bankingproject
{
    class BankRepository : IBankRepository
    {
        List<SBAccount> accounts = new List<SBAccount>();
        List<SBTransaction> transactions = new List<SBTransaction>();
        int transactionIdCounter = 1;

        public void DepositAmount(int accno, float amount)
        {
            SBAccount account = GetAccountDetails(accno);
            account.CurrentBalance += amount;

            transactions.Add(new SBTransaction
            {
                TransactionId = transactionIdCounter++,
                TransactionDate = DateTime.Now,
                AccountNumber = accno,
                Amount = amount,
                TransactionType = "Deposit"
            });      
        }

        public SBAccount GetAccountDetails(int accno)
        {
            foreach (SBAccount item in accounts)
            {
                if (item.AccountNumber == accno)
                {
                    return item;
                }
            }
            System.Console.WriteLine("The account does not exist!");
            throw new InvalidOperationException("Account NOT found!");
        }

        public List<SBAccount> GetAllAccounts()
        {
            return accounts;
        }

        public List<SBTransaction> GetTransactions(int accno)
        {
            List<SBTransaction> Transactions = new List<SBTransaction>();
            foreach (SBTransaction item in transactions)
            {
                if (item.AccountNumber == accno)
                {
                    Transactions.Add(item);
                }
            }
            return Transactions;
        }

        public void NewAccount(SBAccount acc)
        {
            accounts.Add(acc);
        }

        public void WithdrawAmount(int accno, float amount)
        {
            var account = GetAccountDetails(accno);
            if (account.CurrentBalance < amount)
            {
                throw new InvalidOperationException("Insufficient balance.");
            }

            account.CurrentBalance -= amount;

            transactions.Add(new SBTransaction
            {
                TransactionId = transactionIdCounter++,
                TransactionDate = DateTime.Now,
                AccountNumber = accno,
                Amount = amount,
                TransactionType = "Withdraw"
            });


        }
    }
}