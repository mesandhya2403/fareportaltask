using System;
using System.Collections.Generic;

namespace Bankingproject
{
    public class SBAccount
    {
        public int AccountNumber { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public float CurrentBalance { get; set; }
         public SBAccount(){}
        public SBAccount(int acc, string customerName, string customerAddress, float currentBalance){
            AccountNumber=acc;
            CustomerName=customerName;
            CustomerAddress=customerAddress;
            CurrentBalance=currentBalance;
        } 

        public override string ToString(){
            return AccountNumber+" "+CustomerName+" "+CustomerAddress+" "+CurrentBalance;
        }
    }
   
    public class SBTransaction
    {
        public int TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public int AccountNumber { get; set; }
        public float Amount { get; set; }
        public string? TransactionType { get; set; }
        public SBTransaction(){}

        public SBTransaction(int tID, DateTime tDate, int acNo, float amount, string tType){
            TransactionId = tID;
            TransactionDate = tDate;
            AccountNumber = acNo;
            Amount = amount;
            TransactionType = tType;
        } 

        public override string ToString(){
            return TransactionId+" "+TransactionDate+" "+AccountNumber+" "+Amount+" "+TransactionType;
        }
    }
}