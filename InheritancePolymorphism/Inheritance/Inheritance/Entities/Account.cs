using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Entities {
    internal class Account {
        public int Number { get; private set; } //With PRIVATE, we can access but not change the attribute
        public string Holder { get; private set; }
        public double Balance { get; protected set; } //With PROTECTED, we can access and change with one subclass

        public Account() { }

        public Account(int number, string holder, double balance) {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount) {
            Balance -= amount;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }
    }
}
