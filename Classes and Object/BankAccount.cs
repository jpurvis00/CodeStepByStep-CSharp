
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

namespace CodeStepByStep_CSharp.Classes_and_Object
{
    public class BankAccount
    {
        private BankAccountModel _account;

        public BankAccount(string name)
        {
            _account =  new BankAccountModel(name);                
        }

        public string GetAccountName()
        {
            return _account.Name;
        }

        public decimal GetAccountBalance()
        {
            return _account.Balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount > 0)
            {
                _account.Balance += amount;
            }

        }

        public void Withdraw(decimal amount)
        {
            if( amount > 0 && amount < _account.Balance)
            {
                _account.Balance -= amount;
            }
        }

        public override string ToString()
        {
            string output;

            if (_account.Balance >= 0)
            {
                output = _account.Name + ", $" + _account.Balance;
            }
            else
            {
                output = _account.Name + ", -$" + Math.Abs(_account.Balance);
            }

            return output;
        }
    }
}
