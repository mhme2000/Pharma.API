using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IPersonRepository
    {
        void Add(PersonModel person);
        PersonModel? GetById(int personId);
        IEnumerable<PersonModel>? GetAll();
        void Delete(PersonModel person);
        void Update(PersonModel person);
    }

}