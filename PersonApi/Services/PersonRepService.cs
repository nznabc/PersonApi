using PersonApi.Models;
using PersonApi.Repositories;

namespace PersonApi.Services
{
    public class PersonRepService : IPersonService
    {
        private readonly IGenericRepository<Person> _repository;

        public PersonRepService(IGenericRepository<Person> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Person>> GetPersonsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Person?> GetPersonByIdAsync(int id)
        {
            return await _repository.GetAsync(id);
        }

        public async Task<Person> SavePersonAsync(Person person)
        {
            return await _repository.SaveAsync(person);
        }

        public async Task<Person> UpdatePersonAsync(Person person)
        {
            return await _repository.UpdateAsync(person);
        }

        public async Task DeletePersonAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
