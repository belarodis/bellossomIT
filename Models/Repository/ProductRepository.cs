using bellossomIT.Models.Enuns;

namespace bellossomIT.Models.Repository;

public class ProductRepository : IProductRepository
{
    private static readonly List<ProductModel> _products = new List<ProductModel>();

    static ProductRepository()
    {
        // Instanciar 10 Fertilizantes
        for (int i = 1; i <= 10; i++)
        {
            _products.Add(new FertilizerModel
            {
                Id = i,
                quantity = 100 + i,
                brand = $"Marca {i}",
                category = FertilizerCategory.NATURAL,
                weight = 5 + i
            });
        }

        // Instanciar 10 Flores
        for (int i = 11; i <= 20; i++)
        {
            _products.Add(new FlowerModel
            {
                Id = i,
                quantity = 50 + i,
                species = $"Espécie {i}",
                arrivalDate = DateTime.UtcNow.AddDays(-i)
            });
        }

        // Instanciar 10 Vasos
        for (int i = 21; i <= 30; i++)
        {
            _products.Add(new VaseModel
            {
                Id = i,
                quantity = 30 + i,
                material = VaseMaterial.CERAMIC,
                size = VaseSize.M
            });
        }
    }

    public List<ProductModel> GetAll()
    {
        return _products;
    }
}