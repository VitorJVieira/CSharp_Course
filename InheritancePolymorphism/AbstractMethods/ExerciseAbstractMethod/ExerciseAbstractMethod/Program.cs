using ExerciseAbstractMethod.Entities;

namespace ExerciseAbstractMethod {
    internal class Program {
        static void Main(string[] args) {
            
            List<Payers> payers = new List<Payers>();

            Console.Write("Enter the number of payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine());
                if (type == 'i') {
                    Console.Write("Health expenditures: ");
                    double expenditures = double.Parse(Console.ReadLine());
                    payers.Add(new Individual(expenditures, name, income));
                } else {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    payers.Add(new Company(employees, name, income));
                }
            };

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            double total = 0;
            foreach (Payers payer in payers) {
                Console.WriteLine(payer.Name + ": R$ " + payer.Taxes().ToString("F2"));
                total += payer.Taxes();
            }

            Console.WriteLine("Total taxes: R$ " + total.ToString("F2"));


        }
    }
}