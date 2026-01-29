public class Customer
{
  private string _name;
  private Address _address;

  public Customer(string name, Address address)
  {
    _name = name;
    _address = address;
  }

  public bool countryCheck()
  {
    return _address.isNational();
  }

  public string displayAddress()
  {
    return $"{_name} \n{_address.displayAddress()}";
  }
}