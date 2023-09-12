using Exercise01.Entities.Enums;

namespace Exercise01.Entities {
    internal class Worker {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Worker must have a Department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //list because worker have more than 1 contract

        public Worker () { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            //When it has a multiple part, it's not recommended to put in the constructor
        }

        public void addContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }


    }
}
