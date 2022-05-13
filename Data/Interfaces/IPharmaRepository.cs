using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IPharmaRepository
    {
        void Add(PharmaModel pharma);
        PharmaModel? GetById(int pharmaId);
        IEnumerable<PharmaModel>? GetAll();
        void Delete(PharmaModel pharma);
        void Update(PharmaModel pharma);
    }

}