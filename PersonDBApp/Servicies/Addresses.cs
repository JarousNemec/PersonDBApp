using System.Reflection;
using PersonDBApp.Models;

namespace PersonDBApp.Servicies;

public class Addresses
{
    private readonly Database _database;
    private readonly List<Address> _addresses;

    public delegate void AddressesUpdatedDelegate();

    public event AddressesUpdatedDelegate AddressesUpdated;
    public DateTime LastUpdate { get; private set; }

    public Addresses(Database database)
    {
        _database = database;
        _addresses = new List<Address>();
    }

    public int AddressesCount() => _addresses.Count;

    public List<Address> GetAddresses(bool refresh = false)
    {
        if (refresh || _addresses.Count == 0)
            Refresh();
        return _addresses;
    }

    private void Refresh()
    {
        var persons = _database.GetAddresses();
        _addresses.Clear();
        if (persons == null) return;
        _addresses.AddRange(persons);
        LastUpdate = DateTime.Now;
    }

    public Address? GetAddressById(int id, bool refresh = false)
    {
        if (refresh || _addresses.Count == 0)
            Refresh();
        return _addresses.FirstOrDefault(x => x.AddressId == id);
    }

    public bool InsertAddress(Address address, bool refresh = false)
    {
        if (refresh || _addresses.Count == 0)
            Refresh();
        var type = typeof(Address);
        IList<PropertyInfo> props = new List<PropertyInfo>(type.GetProperties());
        foreach (var a in _addresses)
        {
            var containsCurrentAddress = true;
            foreach (var prop in props)
            {
                if (prop.Name == "AddressId")
                    continue;
                var value1 = (string)prop.GetValue(a, null);
                var value2 = (string)prop.GetValue(address, null);
                if (value1 != value2)
                {
                    containsCurrentAddress = false;
                    break;
                }
            }

            if (containsCurrentAddress)
                return false;
        }

        _addresses.Add(address);

        var res = _database.InsertAddress(address);
        if (res) AddressesUpdated?.Invoke();
        return res;
    }
}