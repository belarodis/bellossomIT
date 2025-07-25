using bellossomIT.Models.Enuns;

namespace bellossomIT.Models.Repository;

public class ProductRepository : IProductRepository
{
    private static readonly List<ProductModel> _products = new List<ProductModel>();
    private static int _nextId = 31;

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
    
    public Task<List<FlowerModel>> GetAllFlowersAsync()
    {
        var flowers = _products.OfType<FlowerModel>().ToList();
        return Task.FromResult(flowers);
    }

    public Task<List<FertilizerModel>> GetAllFertilizersAsync()
    {
        var fertilizers = _products.OfType<FertilizerModel>().ToList();
        return Task.FromResult(fertilizers);
    }

    public Task<List<VaseModel>> GetAllVasesAsync()
    {
        var vases = _products.OfType<VaseModel>().ToList();
        return Task.FromResult(vases);
    }

    public Task AddAsync(ProductModel product)
    {
        product.Id = _nextId++;
        _products.Add(product);
        return Task.CompletedTask;
    }
    
    public Task UpdateAsync(ProductModel product)
    {
        var index = _products.FindIndex(p => p.Id == product.Id);
        if (index != -1)
        {
            _products[index] = product;
        }
        return Task.CompletedTask;
    }

    public Task DeleteAsync(ProductModel product)
    {
        if (product != null)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing != null)
            {
                _products.Remove(existing);
            }
        }
        return Task.CompletedTask;
    }


    public Task DecreaseQuantity(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null && product.quantity > 0)
        {
            product.quantity--;
        }
        return Task.CompletedTask;
    }
    
    public Task IncreaseQuantity(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product != null && product.quantity >= 0)
        {
            product.quantity++;
        }
        return Task.CompletedTask;
    }
}