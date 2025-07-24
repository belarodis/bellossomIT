using bellossomIT.Models;

namespace bellossomIT.Service;

public interface IProductService
{
    Task<List<FlowerModel>> GetAllFlowersAsync();
    Task<List<FertilizerModel>> GetAllFertilizersAsync();
    Task<List<VaseModel>> GetAllVasesAsync();

    Task AddAsync(ProductModel product);
    Task UpdateAsync(ProductModel product);
    Task RemoveAsync(ProductModel product);
}