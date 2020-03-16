namespace ACM.BL {
    public class Product {
        public Product() {
        }

        public Product(int productId) {
            this.ProductId = ProductId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId) {
            // Code to retrieves the defined product
            return new Product();
        }

        public bool Save() {
            // Code that saves the defined product
            return true;
        }

        public bool Validate() {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}