
//Write a class of objects named BankAccount that remembers
//information about a user's account at a bank. You must include
//the following public members:

//member name	            type	        description
//new BankAccount(name)     constructor     constructs a new account for the person with the given name, with $0.00 balance
//ba.Name                   property        the account name as a string(read - only)
//ba.Balance                property        the account balance as a real number(read - only)
//ba.Deposit(amount);       method          adds the given amount of money, as a real number, to the account balance; if the amount is negative, does nothing
//ba.Withdraw(amount);      method          subtracts the given amount of money, as a real number, from the account balance; if the amount is negative or exceeds the account's balance, does nothing

//You should define the entire class including the class heading, the
//private instance variables, and the declarations and definitions of
//all the public member functions and constructor.

using CodeStepByStep_CSharp.Classes_and_Object.Model;
using System.Reflection.Metadata.Ecma335;

namespace CodeStepByStep_CSharp.Classes_and_Object
{
    public static class BankAccount
    {
        public static string GetAccountName(BankAccountModel account)
        {
            return account.Name;
        }

        public static decimal GetAccountBalance(BankAccountModel account)
        {
            return account.Balance;
        }

        public static void Deposit(decimal amount, BankAccountModel account)
        {
            if(amount > 0)
            {
                account.Balance += amount;
            }

            account.NumberOfTransactions++;
        }

        public static void Withdraw(decimal amount, BankAccountModel account)
        {
            if (amount > 0 && amount < account.Balance)
            {
                account.Balance -= amount;
            }

            account.NumberOfTransactions++;
        }

        public static bool TransactionFee(decimal feeAmount, BankAccountModel account)
        {
            decimal transactionFeeDeductionAmount = 0;

            for (int i = 1; i <= account.NumberOfTransactions; i++)
            {
                transactionFeeDeductionAmount += feeAmount * i;
            }

            if (account.Balance - transactionFeeDeductionAmount > 0)
            {
                account.Balance -= transactionFeeDeductionAmount;
                return true;
            }
            else
            {
                account.Balance = 0;
                return false;
            }
        }

        public static void Transfer(decimal transferAmount, BankAccountModel fromAccount, BankAccountModel toAccount)
        {
            decimal transferFee = 5.00M;

            if (transferAmount < 0)
            {
                return;
            }

            if (fromAccount.Balance >= (transferAmount + transferFee))
            {
                fromAccount.Balance -= (transferAmount + transferFee);
                fromAccount.NumberOfTransactions++;

                toAccount.Balance += transferAmount;
                toAccount.NumberOfTransactions++;
            }
            else if (fromAccount.Balance < 5.00M)
            {
                return;
            }
            else
            {
                decimal amountToTransfer = 0;

                fromAccount.Balance -= transferFee;
                amountToTransfer = fromAccount.Balance;
                fromAccount.Balance = 0;
                fromAccount.NumberOfTransactions++;

                toAccount.Balance += amountToTransfer;
                toAccount.NumberOfTransactions++;
            }
        }
    }
}
