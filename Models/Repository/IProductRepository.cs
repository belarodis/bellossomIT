namespace bellossomIT.Models.Repository;

public interface IProductRepository
{
    Task<List<FlowerModel>> GetAllFlowersAsync();
    Task<List<FertilizerModel>> GetAllFertilizersAsync();
    Task<List<VaseModel>> GetAllVasesAsync();
    
    Task AddAsync(ProductModel product);
    Task UpdateAsync(ProductModel product);
    Task DeleteAsync(ProductModel product);
    Task IncreaseQuantity(int id);
    Task DecreaseQuantity(int id);
}