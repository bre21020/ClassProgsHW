public class Product {
    string _Name;
    string _ProductId;
    decimal _PricePerUnit;
    decimal _Quantity;
    public Product(string Name, string ProductId, decimal PricePerUnit, decimal Quantity) {
        _Name = Name;
        _ProductId = ProductId;
        _PricePerUnit = PricePerUnit;
        _Quantity = Quantity;

    }
    public decimal GetTotalPrice()
    {
        decimal TotalPrice = _Quantity * _PricePerUnit;
        return TotalPrice;
    }
    public string GetName() {
        return _Name;
    }
    public string GetProductId() {
        return _ProductId;
    }
}