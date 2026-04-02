public class Order {
    List<Product> _products = new List<Product>();
    Customer _customer;
    public Order(Customer customer, List<Product> Products) {
        _customer = customer;
        _products = Products;
    }
    public string GetTotalPrice()
    {
        decimal Price = 0;
        foreach (Product Product in _products) {
            decimal AddToPrice = Product.GetTotalPrice();
            Price += AddToPrice;
        }
        Price += _customer.GetShippingCost();
        return "TOTAL: $" + Price;
    }
    public string GetPackingLabel() {
        string PackingLabel = "";
        foreach (Product Product in _products) {
            string AddToPackingLabel = Product.GetName() + " " + Product.GetProductId() + "\n";
            PackingLabel += AddToPackingLabel;
        }
        
        return PackingLabel;
    }
    public string GetShippingLabel() {
        string ShippingLabel =  _customer.GetName() + "\n" + _customer.GetFullAddress(_customer.GetAddress());
        return ShippingLabel;
    }
}    
