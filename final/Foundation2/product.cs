public class Product {
    string _name;
    string _productId;
    decimal _pricePerUnit;
    decimal _quantity;
    public Product(string Name, string ProductId, decimal PricePerUnit, decimal Quantity) {
        _name = Name;
        _productId = ProductId;
        _pricePerUnit = PricePerUnit;
        _quantity = Quantity;

    }
    public decimal GetTotalPrice()
    {
        decimal TotalPrice = _quantity * _pricePerUnit;
        return TotalPrice;
    }
    public string GetName() {
        return _name;
    }
    public string GetProductId() {
        return _productId;
    }
}