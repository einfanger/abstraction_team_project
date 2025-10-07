using System;

public class Address
{
private string _street;
private string _city;
private string _state;
private string _zipCode;
public Adress(string street, string city, string state, string zipCode) 
    {_street = street;
    _city = city;
    _state = state;
    _zipCode = zipCode;
}
public void DisplayMailingLabel()

{
    Console.WriteLine(_street);
    Console.WriteLine($"{_city}, {_state} {_zipCode}");
}
}