using Inheritance.Entities;

namespace Inheritance {
    internal class Program {
        static void Main(string[] args) {

            //Inheritance allow to reuse attributes and methods
            //In this example, the Bussines Account will inherit attributes and methods from Account
            
            /* Example of inheritance 
            
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            account.Balance = 200; This is not going to work because is private */

            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            // UPCASTING

            Account acc1 = bacc; // It's going to work beacuse Bussines Account IS a type of Account

            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);

            Account acc3 = new SavingsAccount(1004,"Ana", 0.0, 0.1);

            // DOWNCASTING

            //BusinessAccount acc4 = acc2; *** It's NOT going to work because the "acc2" variable is Account. The solution is:
            BusinessAccount acc4 = (BusinessAccount)acc2;

            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3; *** It not show an error here, but if we run the program, it shows an Exception because they're not compatible
            if (acc3 is  BusinessAccount) {
                BusinessAccount acc5 = (BusinessAccount)acc3; //The casting could be used like this: BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            
            if (acc3 is SavingsAccount) {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }

        }
    }
}