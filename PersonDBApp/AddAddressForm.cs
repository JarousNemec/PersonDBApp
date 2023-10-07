using System.Windows.Forms;
using PersonDBApp.Models;

namespace PersonDBApp;

public partial class AddAddressForm : Form
{
    
    public delegate void AddAddressDelegate(Address address);

    public event AddAddressDelegate AddAddress;
    public AddAddressForm()
    {
        InitializeComponent();
    }

    private void _btnAddAddress_Click(object sender, EventArgs e)
    {
        var street = _txtStreet.Text;
        var city = _txtCity.Text;
        var zip = _txtZip.Text;
        var country = _txtCountry.Text;
        
        AddAddress?.Invoke(new Address(){City = city, Country = country, Street = street, Zip = zip});
    }
}