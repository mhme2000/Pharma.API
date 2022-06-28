namespace Pharma.API.Model
{
    public class ProductTypeModel
    {
        public int ProductTypeId { get; private set; }
        public ProductType Description { get; set; }
        private readonly List<ProductModel> _products = new List<ProductModel>();
        public IReadOnlyCollection<ProductModel> Products => _products;

        public enum ProductType
        {
            Insumos = 1,
            Medicamentos = 2,
            Outros = 3,
        }
    }
}

// INSERT INTO public."ProductType"
//     ("Description")
// VALUES('Insumos');
//
// INSERT INTO public."ProductType"
//     ("Description")
// VALUES('Medicamentos');
//
// INSERT INTO public."ProductType"
//     ("Description")
// VALUES('Outros');
