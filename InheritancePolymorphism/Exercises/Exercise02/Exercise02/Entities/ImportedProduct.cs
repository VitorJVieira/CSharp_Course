namespace Exercise02.Entities {
    class ImportedProduct : Product {

        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee) : base(name, price) {
            CustomFee = customFee;
        }

        public double totalPrice() {
            return Price + CustomFee;
        }

        public override string priceTag() {
            return Name + " $ " + totalPrice() + " (Customs fee: $ " + CustomFee + ")";   
        }
    }
}
