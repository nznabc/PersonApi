using PersonApi.Models;

namespace PersonApi.Services
{
    public interface IPersonService
    {
        /// <summary>
        /// Get Persons
        /// </summary>
        /// <returns></returns>
        public Task<IEnumerable<Person>> GetPersonsAsync();

        /// <summary>
        /// Get person by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task<Person?> GetPersonByIdAsync(int id);

        /// <summary>
        /// Save Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Task<Person> SavePersonAsync(Person person);

        /// <summary>
        /// Update Person
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public Task<Person> UpdatePersonAsync(Person person);

        /// <summary>
        /// Delete Person
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Task DeletePersonAsync(int id);
    }
}
