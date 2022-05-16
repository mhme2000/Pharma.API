using Microsoft.EntityFrameworkCore;
using Pharma.API.Data.Interfaces;
using Pharma.API.Model;

namespace Pharma.API.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly PharmaContext _context;
        public UserRepository(PharmaContext context)
        {
            _context = context;
        }
        public void Add(UserModel user)
        {
            _context.User?.Add(user);
            _context.SaveChanges();
        }

        public UserModel? GetById(int userId)
        {
            return _context.User?.AsNoTracking().Include(r => r.UserType).Include(s => s.Person).Include(u => u.Pharma).FirstOrDefault(t => t.UserId == userId);
        }

        public IEnumerable<UserModel>? GetAll()
        {
            return _context.User?.Where(t => t.UserId > 0).Include(r => r.UserType).Include(s => s.Person).Include(u => u.Pharma);
        }

        public void Update(UserModel user)
        {
            _context.User?.Update(user);
            _context.SaveChanges();
        }

        public void Delete(UserModel user)
        {
            _context.User?.Remove(user);
            _context.SaveChanges();
        }
    }

}