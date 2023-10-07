namespace PersonDBApp.Models;

public class Address
{
    public int AddressId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }

    public override string ToString()
    {
        return $"{Street} {City} {Zip} {Country}";
    }
}