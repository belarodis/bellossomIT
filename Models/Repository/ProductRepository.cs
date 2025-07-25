using bellossomIT.Models.Enuns;

namespace bellossomIT.Models.Repository;

public class ProductRepository : IProductRepository
{
    private static readonly List<ProductModel> _products = new List<ProductModel>();
    private static int _nextId = 24;

    static ProductRepository()
    {
        _products.Add(new VaseModel
            {
                Id = 1,
                quantity = 10,
                material = VaseMaterial.CERAMIC,
                size = VaseSize.S
            });
        _products.Add(new VaseModel
            {
                Id = 2,
                quantity = 5,
                material = VaseMaterial.CERAMIC,
                size = VaseSize.M
            });
        _products.Add(new VaseModel
            {
                Id = 3,
                quantity = 8,
                material = VaseMaterial.CERAMIC,
                size = VaseSize.L
            });
            _products.Add(new VaseModel
            {
                Id = 4,
                quantity = 5,
                material = VaseMaterial.PLASTIC,
                size = VaseSize.S
            });
        _products.Add(new VaseModel
            {
                Id = 5,
                quantity = 2,
                material = VaseMaterial.PLASTIC,
                size = VaseSize.M
            });
        _products.Add(new VaseModel
            {
                Id = 6,
                quantity = 4,
                material = VaseMaterial.PLASTIC,
                size = VaseSize.L
            });

        _products.Add(new FertilizerModel
            {
                Id = 7,
                quantity = 34,
                brand = "Tiliza",
                category = FertilizerCategory.NATURAL,
                weight = 500
            });
        _products.Add(new FertilizerModel
            {
                Id = 8,
                quantity = 17,
                brand = "Verdinho",
                category = FertilizerCategory.NATURAL,
                weight = 1000
            });
        _products.Add(new FertilizerModel
            {
                Id = 9,
                quantity = 12,
                brand = "KillSect",
                category = FertilizerCategory.SYNTHETIC,
                weight = 1000
            });
        _products.Add(new FertilizerModel
            {
                Id = 10,
                quantity = 2,
                brand = "OtherGreenSide",
                category = FertilizerCategory.SYNTHETIC,
                weight = 500
            });
        _products.Add(new FertilizerModel
            {
                Id = 11,
                quantity = 4,
                brand = "GriPawa",
                category = FertilizerCategory.NATURAL,
                weight = 1000
            });

        

        _products.Add(new FlowerModel
        {
            Id = 12,
            quantity = 23,
            species = "Rosa (Rosa híbrida)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 13,
            quantity = 15,
            species = "Tulipa (Tulipa gesneriana)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 14,
            quantity = 30,
            species = "Orquídea Phalaenopsis (Phalaenopsis spp.)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 15,
            quantity = 20,
            species = "Girassol (Helianthus annuus)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 16,
            quantity = 25,
            species = "Lírio (Lilium orientalis)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 17,
            quantity = 18,
            species = "Hortênsia (Hydrangea macrophylla)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 18,
            quantity = 22,
            species = "Margarida (Leucanthemum vulgare)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 19,
            quantity = 12,
            species = "Lavanda (Lavandula angustifolia)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 20,
            quantity = 28,
            species = "Copo-de-leite (Zantedeschia aethiopica)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 21,
            quantity = 16,
            species = "Peônia (Paeonia lactiflora)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 22,
            quantity = 19,
            species = "Violeta-africana (Saintpaulia ionantha)",
            arrivalDate = DateTime.UtcNow
        });

        _products.Add(new FlowerModel
        {
            Id = 23,
            quantity = 24,
            species = "Antúrio (Anthurium andraeanum)",
            arrivalDate = DateTime.UtcNow
        });
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