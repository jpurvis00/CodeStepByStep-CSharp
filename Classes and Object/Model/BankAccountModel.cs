using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeStepByStep_CSharp.Classes_and_Object.Model
{
    public class BankAccountModel
    {
        public BankAccountModel(string name)
        {
            Name = name;
            Balance = 0M;
        }

        public string Name { get; set; }
        
        public decimal Balance { get; set; }

        public int NumberOfTransactions { get; set; } = 0;

        public override string ToString()
        {
            string output;

            if (Balance >= 0)
            {
                output = Name + ", $" + Balance;
            }
            else
            {
                output = Name + ", -$" + Math.Abs(Balance);
            }

            return output;
        }
    }
}
