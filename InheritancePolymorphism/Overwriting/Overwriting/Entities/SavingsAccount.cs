using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwriting.Entities {
    sealed class SavingsAccount : Account {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance) {
            InterestRate = interestRate;
        }

        public void UpdateBalance() {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) {
            //Balance -= amount;
            base.Withdraw(amount);
            Balance -= amount; //it will keep de - 5 from balance and make another -2
        }
    }
}
