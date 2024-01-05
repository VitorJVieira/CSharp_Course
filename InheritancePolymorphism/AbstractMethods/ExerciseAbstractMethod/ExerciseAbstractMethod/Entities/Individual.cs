using ExerciseAbstractMethod.Entities;

namespace ExerciseAbstractMethod.Entities {
    internal class Individual : Payers {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double income) : base(name, income) {
            
        }

        public Individual(double healthExpenditures, string name, double income) : base(name, income) {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes() {
            if (HealthExpenditures != 0) {
                if (Income >= 20000) {
                    return (Income * 0.25) - (HealthExpenditures * 0.5);
                } else {
                    return (Income * 0.15) - (HealthExpenditures * 0.5);
                }
            } else {
                if (Income >= 20000) {
                    return (Income * 0.25);
                } else {
                    return (Income * 0.15);
                }
            };
        }
    }
}
