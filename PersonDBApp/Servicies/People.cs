using System.Reflection;
using PersonDBApp.Models;

namespace PersonDBApp.Servicies;

public class People
{
    private readonly Database _database;
    private readonly List<Person> _people;
    public DateTime LastUpdate {get; private set; }

    public People(Database database)
    {
        _database = database;
        _people = new List<Person>();
    }

    public int PersonCount() => _people.Count;

    public IEnumerable<Person> GetPeople(bool refresh = false)
    {
        if (refresh || _people.Count == 0)
            Refresh();
        return _people;
    }

    public void Refresh()
    {
        var persons = _database.GetPersons();
        _people.Clear();
        if (persons == null) return;
        _people.AddRange(persons);
        LastUpdate = DateTime.Now;
    }

    public Person? GetPersonById(Guid id)
    {
        return _people.FirstOrDefault(x => x.PersonId == id);
    }
    
    public bool InsertPerson(Person person, bool refresh = false)
    {
        if (refresh || _people.Count == 0)
            Refresh();
        
        _people.Add(person);
        return _database.InsertPerson(person);
    }
}