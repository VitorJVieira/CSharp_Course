namespace ExerciseAbstractMethod.Entities {
    abstract class Payers {

        public string Name { get; set; }

        public double Income { get; set; }

        public Payers(string name, double income) { 
            Name = name; 
            Income = income;
        }

        public abstract double Taxes();

        
    }
}
