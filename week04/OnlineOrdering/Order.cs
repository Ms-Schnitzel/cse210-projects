public class Order
{
  private List<Product> _products;
  private Customer _customer;

  public Order(List<Product> products, Customer customer)
  {
    _products = products;
    _customer = customer;
  }

  public double calcTotal()
  {
    // total = sum of each product cost + one-time shipping fee
    // if US, shipping = $5, else shipping = $35
    double total = 0;
    if (_customer.countryCheck() == true)
    {
      total += 5;
    }
    else
    {
      total += 35;
    }
    foreach (Product product in _products)
    {
      total += product.calcCost();
    }

    return total;
  }

  public string returnShippingLabel()
  {
    // list name and address of customer
    return _customer.displayAddress();
  }
  
  public string returnPackingLabel()
  {
    // list name and product id of each product in order
    string label = $"";
    foreach (Product product in _products)
    {
      label += product.displayProduct();
    }
    return label;
  }
}