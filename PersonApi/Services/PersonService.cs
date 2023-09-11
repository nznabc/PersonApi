using Microsoft.EntityFrameworkCore;
using PersonApi.Models;

namespace PersonApi.Services
{
    /// <summary>
    /// S:single responsibility. it means each class has just one task to do. each class has only one reason to change.
    /// O: Open-closed principle. it means each class should be open to extend but close to modification. we need to design our classes in a way we can add features to them without needing to change our classes. for instance using inheritence or abstract classes are a way to achieve Open-close principle.
    /// L: Liskov. it means child classes should have the same behaviour as their parent class. using Inheritence, abract classes and polymorphism are a way to achieve this principle. 
    /// I: interface segragation. it means the user shouldn't implement all the methods that they don't need them. instead of one big interface we can divide them into multiple interfaces that relates to each other.
    /// D: dependency inversion principle. it means a class should depend on abstraction not concretions. DI is used to removing the concrete dependency between our classes and services. we create an interface with all required method and let IOC create a concrete implementation.
    /// </summary>
    public sealed class PersonService : IPersonService
    {
        private readonly DataContext _context;

        public PersonService(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            return await _context.Persons.ToListAsync();
        }

        public async Task<Person?> GetPersonByIdAsync(int id)
        {

            return await _context.Persons.FindAsync(id);


        }

        public async Task<Person> SavePersonAsync(Person person)
        {
            var p = await _context.Persons.AddAsync(person);

            await _context.SaveChangesAsync();

            return p.Entity;
        }

        public async Task<Person> UpdatePersonAsync(Person person)
        {
            var p = await GetPersonByIdAsync(person.Id);

            p.Name = person.Name;

            p.Family = person.Family;

            await _context.SaveChangesAsync();

            return p;
        }

        public async Task DeletePersonAsync(int id)
        {
            await _context.Persons.Where(x => x.Id == id).ExecuteDeleteAsync();
        }


    }
}
