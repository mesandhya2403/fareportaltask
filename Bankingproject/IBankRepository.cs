namespace Bankingproject
{
   public interface IBankRepository
    {
        void NewAccount(SBAccount acc);
        List<SBAccount> GetAllAccounts();
        SBAccount GetAccountDetails(int accno);
        void DepositAmount(int accno, float amt);
        void WithdrawAmount(int accno, float amt);
        List<SBTransaction> GetTransactions(int accno);
    }
}