namespace PersonDBApp.Models;

public class Person
{
    public Guid PersonId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime Birthday { get; set; }
    public int AddressId { get; set; }
    public Sex Sex { get; set; }

    public override string ToString()
    {
        return $"{Name} {Surname}";
    }

    public string FullInfo=> $"{Name} {Surname} {Birthday} {Sex.ToString()}";
}