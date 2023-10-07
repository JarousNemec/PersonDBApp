using System.Data;
using Microsoft.Data.SqlClient;
using PersonDBApp.Models;

namespace PersonDBApp.Servicies;

public class Database
{
    private readonly string _connString;
    private readonly SqlConnection _connection;

    public delegate void ErrorDelegate(Exception error);

    public event ErrorDelegate OnDbError;

    public delegate void PersonsErrorDelegate(Exception error);

    public event PersonsErrorDelegate GetPeopleError;
    public event PersonsErrorDelegate InsertPersonError;

    public delegate void AddressesErrorDelegate(Exception error);

    public event AddressesErrorDelegate GetAllAddressesError;
    public event AddressesErrorDelegate InsertAddressError;
    public bool IsConnected => _connection.State == ConnectionState.Open;

    public Database()
    {
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        builder.DataSource = "localhost";
        builder.InitialCatalog = "PersonAppDb";
        builder.UserID = "PersonAppLogin";
        builder.Password = "Heslo1234.";
        builder.TrustServerCertificate = true;
        _connString = builder.ConnectionString;
        _connection = new SqlConnection(_connString);
    }

    public void Connect()
    {
        try
        {
            _connection.Open();
        }
        catch (Exception e)
        {
            OnDbError?.Invoke(e);
        }
    }

    public IEnumerable<Person>? GetPersons(int count = 10)
    {
        var sqlCommand =
            $"SELECT TOP ({count}) [person_id] ,[name] ,[surname] ,[sex] ,[birthday] ,[address_id] FROM [PersonAppDb].[dbo].[Person]";

        var result = new List<Person>();
        try
        {
            using (SqlCommand command = new(sqlCommand, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new()
                        {
                            PersonId = new Guid(reader.GetString(0)),
                            AddressId = reader.GetInt32(5),
                            Birthday = reader.GetDateTime(4),
                            Name = reader.GetString(1),
                            Sex = (Sex)reader.GetInt32(3),
                            Surname = reader.GetString(2)
                        });
                    }
                }
            }
        }
        catch (Exception e)
        {
            GetPeopleError?.Invoke(e);
        }

        return result;
    }
    public IEnumerable<Address>? GetAddresses(int count = 10)
    {
        var sqlCommand =
            $"SELECT TOP ({count}) [address_id], [street], [city], [zip], [country] FROM [PersonAppDb].[dbo].[Address]";

        List<Address> result = new List<Address>();;
        try
        {
            using (SqlCommand command = new(sqlCommand, _connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(new Address()
                        {
                            AddressId = reader.GetInt32(0),
                            City = reader.GetString(2),
                            Country = reader.GetString(4),
                            Street = reader.GetString(1),
                            Zip = reader.GetString(3)
                        });
                    }
                }
            }
        }
        catch (Exception e)
        {
            GetAllAddressesError?.Invoke(e);
        }

        return result;
    }

    public bool InsertAddress(Address address)
    {
        var sqlCommand =
            $"INSERT INTO [PersonAppDb].[dbo].[Address] ([street], [city], [zip], [country]) VALUES ('{address.Street}','{address.City}','{address.Zip}','{address.Country}')";
        try
        {
            using (SqlCommand command = new(sqlCommand, _connection))
            {
                var result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
        }
        catch (Exception e)
        {
            InsertAddressError?.Invoke(e);
            return false;
        }

        return false;
    }
    
    public bool InsertPerson(Person person)
    {
        var sqlCommand =
            $"INSERT INTO [PersonAppDb].[dbo].[Person] ([person_id] ,[name] ,[surname] ,[sex] ,[birthday] ,[address_id]) VALUES ('{person.PersonId}','{person.Name}','{person.Surname}','{(int)person.Sex}','{person.Birthday}','{person.AddressId}')";
        try
        {
            using (SqlCommand command = new(sqlCommand, _connection))
            {
                var result = command.ExecuteNonQuery();
                if (result == 1)
                    return true;
            }
        }
        catch (Exception e)
        {
            InsertPersonError?.Invoke(e);
            return false;
        }

        return false;
    }
}