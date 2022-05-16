using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PharmaContext _context;
        public PersonRepository(PharmaContext context)
        {
            _context = context;
        }
        public void Add(PersonModel person)
        {
            _context.Person?.Add(person);
            _context.SaveChanges();
        }

        public PersonModel? GetById(int personId)
        {
            return _context.Person?.AsNoTracking().FirstOrDefault(t => t.PersonId == personId);
        }

        public IEnumerable<PersonModel>? GetAll()
        {
            return _context.Person?.Where(t => t.PersonId > 0);
        }

        public void Update(PersonModel person)
        {
            _context.Person?.Update(person);
            _context.SaveChanges();
        }

        public void Delete(PersonModel person)
        {
            _context.Person?.Remove(person);
            _context.SaveChanges();
        }
    }

}