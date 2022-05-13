using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class PharmaRepository : IPharmaRepository
    {
        private readonly PharmaContext _context;
        public PharmaRepository(PharmaContext context)
        {
            _context = context;
        }
        public void Add(PharmaModel pharma)
        {
            _context.Pharma?.Add(pharma);
            _context.SaveChanges();
        }

        public PharmaModel? GetById(int pharmaId)
        {
            return _context.Pharma?.AsNoTracking().FirstOrDefault(t => t.PharmaId == pharmaId);
        }

        public IEnumerable<PharmaModel>? GetAll()
        {
            return _context.Pharma?.Where(t => t.PharmaId > 0);
        }

        public void Update(PharmaModel pharma)
        {
            _context.Pharma?.Update(pharma);
            _context.SaveChanges();
        }

        public void Delete(PharmaModel pharma)
        {
            _context.Pharma?.Remove(pharma);
            _context.SaveChanges();
        }
    }

}