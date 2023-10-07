using PersonDBApp.Models;
using PersonDBApp.Servicies;

namespace PersonDBApp;

public partial class Form1 : Form
{
    private readonly Database _database;
    private readonly People _people;
    private readonly Addresses _addresses;
    private AddPersonForm _addPersonDialog;
    public Form1()
    {
        InitializeComponent();
        _database = new Database();
        _database.OnDbError += (e) => MessageBox.Show(e.ToString());
        _database.GetPeopleError += (e) => MessageBox.Show(e.ToString());
        _database.InsertAddressError += (e) => MessageBox.Show(e.ToString());
        _database.InsertPersonError += (e) => MessageBox.Show(e.ToString());
        _database.GetAllAddressesError += (e) => MessageBox.Show(e.ToString());
        _people = new People(_database);
        _addresses = new Addresses(_database);
        _addresses.AddressesUpdated += AddressesOnAddressesUpdated;
    }

    private void AddressesOnAddressesUpdated()
    {
        if(_addPersonDialog != null)
            _addPersonDialog.Load(_addresses.GetAddresses(true));
    }

    private void RefreshPeopleLsb()
    {
        _lsbPersons.Items.Clear();
        foreach (var person in _people.GetPeople())
        {
            _lsbPersons.Items.Add(person);
        }
    }

    private void _lsbPersons_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (_lsbPersons.SelectedIndex == -1) return;

        if (_lsbPersons.SelectedItem is not Person item) return;

        var person = _people.GetPersonById(item.PersonId);

        if (person == null) return;

        var address = _addresses.GetAddressById(person.AddressId);

        if (address == null) return;

        UpdateUi(person, address);
    }

    private void UpdateUi(Person person, Address address)
    {
        _lblPerson.Text = person.FullInfo;
        _lblAddress.Text = address.ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        _database.Connect();

        if (_database.IsConnected)
        {
            _people.Refresh();
        }

        RefreshPeopleLsb();
    }

    private void _btnAddAddress_Click(object sender, EventArgs e)
    {
        OpenAddAddressDialog();
    }

    private void OpenAddAddressDialog()
    {
        var addAddressDialog = new AddAddressForm();
        addAddressDialog.AddAddress += (address) =>
        {
            var res = _addresses.InsertAddress(address);
            _ = res
                ? MessageBox.Show("Successfully added address")
                : MessageBox.Show("Cannot add address");
            if (res) addAddressDialog.Close();
        };
        addAddressDialog.Show();
    }

    private void _btnAddPerson_Click(object sender, EventArgs e)
    {
        _addPersonDialog = new AddPersonForm();
        _addPersonDialog.Load(_addresses.GetAddresses());
        _addPersonDialog.RequireToAddAddress += OpenAddAddressDialog;
        
        _addPersonDialog.AddPerson += (person) =>
        {
            var res = _people.InsertPerson(person);
            _ = res
                ? MessageBox.Show("Successfully added person")
                : MessageBox.Show("Cannot add person");
            if (res)
            {
                _addPersonDialog.Close();
                RefreshPeopleLsb();
            };
        };
        _addPersonDialog.Show();
    }
}