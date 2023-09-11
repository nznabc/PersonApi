using Microsoft.AspNetCore.Mvc;
using PersonApi.Models;
using PersonApi.Services;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET: api/Person
        [HttpGet]
        public async Task<IEnumerable<Person>> GetPersons()
        {
            return await _personService.GetPersonsAsync();
        }

        // GET: api/Person/5
        [HttpGet("{id}")]
        public async Task<Person?> GetPerson(int id)
        {
            return await _personService.GetPersonByIdAsync(id);
        }

        // PUT: api/Person/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public async Task<Person> PutPerson(Person person)
        {
            return await _personService.UpdatePersonAsync(person);

            //if (id != person.Id)
            //{
            //    return BadRequest();
            //}

            //_context.Entry(person).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!PersonExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return NoContent();
        }

        // POST: api/Person
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Person>> PostPerson(Person person)
        {
            return await _personService.SavePersonAsync(person);
            //if (_context.Persons == null)
            //{
            //    return Problem("Entity set 'DataContext.Persons'  is null.");
            //}
            //_context.Persons.Add(person);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetPerson", new { id = person.Id }, person);
        }

        // DELETE: api/Person/5
        [HttpDelete("{id}")]
        public async Task DeletePerson(int id)
        {
            await _personService.DeletePersonAsync(id);

            //if (_context.Persons == null)
            //{
            //    return NotFound();
            //}
            //var person = await _context.Persons.FindAsync(id);
            //if (person == null)
            //{
            //    return NotFound();
            //}

            //_context.Persons.Remove(person);
            //await _context.SaveChangesAsync();

            //return NoContent();
        }

        //private bool PersonExists(int id)
        //{
        //    return (_context.Persons?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
