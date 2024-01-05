using ExerciseAbstractMethod.Entities;

namespace ExerciseAbstractMethod.Entities {
    internal class Company : Payers {
        

        public int Employees { get; set; }

                
        public Company(int employees, string name, double income) : base(name, income) {
            Employees = employees;
        }

        public override double Taxes() {
            if (Employees > 10) {
                return Income * 0.14;
            } else {
                return Income * 0.16;
            };
        }
    }
}
