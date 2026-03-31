public class Order {
    List<Product> _Products = new List<Product>();
    Customer _Customer;
    public Order(Customer customer, List<Product> Products) {
        _Customer = customer;
        _Products = Products;
    }
    public string GetTotalPrice()
    {
        decimal Price = 0;
        foreach (Product Product in _Products) {
            decimal AddToPrice = Product.GetTotalPrice();
            Price += AddToPrice;
        }
        Price += _Customer.GetShippingCost();
        return "TOTAL: $" + Price;
    }
    public string GetPackingLabel() {
        string PackingLabel = "";
        foreach (Product Product in _Products) {
            string AddToPackingLabel = Product.GetName() + " " + Product.GetProductId() + "\n";
            PackingLabel += AddToPackingLabel;
        }
        
        return PackingLabel;
    }
    public string GetShippingLabel() {
        string ShippingLabel =  _Customer.GetName() + "\n" + _Customer.GetFullAddress(_Customer.GetAddress());
        return ShippingLabel;
    }
}    
