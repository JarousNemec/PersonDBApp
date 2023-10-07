using System.Windows.Forms;
using PersonDBApp.Models;

namespace PersonDBApp;

public partial class AddPersonForm : Form
{
    public delegate void AddAddressDelegate();

    public event AddAddressDelegate RequireToAddAddress;

    public delegate void AddPersonDelegate(Person person);

    public event AddPersonDelegate AddPerson;
    
    private DateTime _chosenDate = DateTime.Now;
    
    public AddPersonForm()
    {
        InitializeComponent();
    }

    public void Load(List<Address> addresses)
    {
        _cmbAddress.Items.Clear();
        _cmbSex.Items.Clear();
        _cmbAddress.Items.AddRange(addresses.ToArray());
        foreach (var value in Enum.GetValues(typeof(Sex)))
        {
            _cmbSex.Items.Add(((Sex)value));
        }
    }
    private void _btnAddPerson_Click(object sender, EventArgs e)
    {
        AddPerson?.Invoke(new Person()
        {
            PersonId = Guid.NewGuid(), Name = _txtName.Text, Surname = _txtSurname.Text, Birthday = _chosenDate, Sex = ((Sex)_cmbSex.SelectedItem), AddressId = ((Address)(_cmbAddress.SelectedItem)).AddressId
        });
    }

    private void _btnAddAddress_Click(object sender, EventArgs e)
    {
        RequireToAddAddress?.Invoke();
    }

    private void _mcBirthday_DateSelected(object sender, DateRangeEventArgs e)
    {
        _chosenDate = e.Start;
    }
}