namespace AbstractClass.Entities {
    internal class BusinessAccount : Account {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) {
            //Not need to add the constructors here because we're using the "base" above
            LoanLimit = loanLimit;
        }

        public void Loan(double amount) {
            if (amount <= LoanLimit) {
                Balance += amount;
            }
        }
    }
}
