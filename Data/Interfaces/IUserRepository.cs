using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IUserRepository
    {
        void Add(UserModel user);
        UserModel? GetById(int userId);
        IEnumerable<UserModel>? GetAll();
        void Delete(UserModel user);
        void Update(UserModel user);
    }

}