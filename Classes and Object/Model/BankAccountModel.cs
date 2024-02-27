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
    }
}
