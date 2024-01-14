namespace Bankingproject
{
    class BankClient
    {
        static void Main()
        {
            IBankRepository SBA = new BankRepository();

            while (true)
            {
                Console.WriteLine("Choose any of the following options");
                Console.WriteLine("1. Creating a New Account");
                Console.WriteLine("2. Get Details of any Account");
                Console.WriteLine("3. Get Details of all the Accounts");
                Console.WriteLine("4. Deposit Amount");
                Console.WriteLine("5. Withdraw Amount");
                Console.WriteLine("6. Get details of transactions");

                Console.Write("Enter any options: ");

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        // New Account
                        Console.Write("Enter Customer Name: ");
                        string? customerName = Console.ReadLine();

                        Console.Write("Enter Customer Address: ");
                        string? customerAddress = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        float initialBalance = float.Parse(Console.ReadLine());

                        Console.Write("Enter Account Number: ");
                        int accno = Convert.ToInt32(Console.ReadLine());

                        SBA.NewAccount(new SBAccount(accno,customerName,customerAddress,initialBalance));

                       System.Console.WriteLine("Account added successfully.");
                        break;

                    case 2:
                        // Get Details of an Account
                        Console.Write("Enter Account Number: ");
                        int accountNumber = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            SBAccount accountDetails = SBA.GetAccountDetails(accountNumber);
                            Console.WriteLine($"Account Details:\n Name:{accountDetails.CustomerName}\n Address: {accountDetails.CustomerAddress}\n Balance: {accountDetails.CurrentBalance}");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 3:
                        // Get Details of all Accounts
                        List<SBAccount> allAccounts = SBA.GetAllAccounts();
                        Console.WriteLine("All Accounts:");
                        foreach (var account in allAccounts)
                        {
                            Console.WriteLine($"Account Number: {account.AccountNumber},\nCustomer Name: {account.CustomerName},\nBalance: {account.CurrentBalance}");
                        }
                        break;

                    case 4:
                        // Deposit Amount
                        Console.Write("Enter Account Number: ");
                        int depositAccountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Deposit Amount: ");
                        float depositAmount = Convert.ToInt32(Console.ReadLine());

                        try
                        {
                            SBA.DepositAmount(depositAccountNumber, depositAmount);
                            Console.WriteLine("Amount deposited successfully");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 5:
                        // Withdraw Amount
                        Console.Write("Enter Account Number: ");
                        int withdrawAccountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Withdrawal Amount: ");
                        float withdrawAmount = float.Parse(Console.ReadLine());

                        try
                        {
                            SBA.WithdrawAmount(withdrawAccountNumber, withdrawAmount);
                            Console.WriteLine("Amount withdrawn successfully");
                            
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 6:
                     System.Console.WriteLine("Enter the Account No: ");
                     int transactionsAcNo = Convert.ToInt32(System.Console.ReadLine());
                     List<SBTransaction> allTransactions = new List<SBTransaction>(SBA.GetTransactions(transactionsAcNo));
                     if(!allTransactions.Any()){
                    System.Console.WriteLine("No record available for this account!");
                     }
                    else{
                    foreach(SBTransaction item in allTransactions){
                        System.Console.WriteLine(item);
                    }
                    }
                    break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}