namespace AbstractClass.Entities {
    internal class SavingsAccount : Account {
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
            Balance -= 2; //it will keep de - 5 from balance and make another -2
        }
    }
}
