using Pharma.API.Model;

namespace Pharma.API.Data.Interfaces
{
    public interface IProductRepository
    {
        void Add(ProductModel product);
        ProductModel? GetById(int productId);
        IEnumerable<ProductModel>? GetAll();
        void Delete(ProductModel product);
        void Update(ProductModel product);
    }

}