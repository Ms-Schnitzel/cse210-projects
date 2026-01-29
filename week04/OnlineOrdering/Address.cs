public class Address
{
  private string _street;
  private string _city;
  private string _state;
  private string _country;

  public Address(string street, string city, string state, string country)
  {
    _street = street;
    _city = city;
    _state = state;
    _country = country;
  }

  public bool isNational()
  {
    // return true if address is in US, false if out of US
    if (_country == "USA")
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  public string displayAddress()
  {
    return $"{_street} \n{_city}, {_state} \n{_country}";
  }
}