namespace bellossomIT.Services;
using bellossomIT.Models;
using bellossomIT.Repository;

public class ProductService
{
    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;
    }
    
    public Task<List<FlowerModel>> GetAllFlowersAsync()
    {
        return _repository.GetAllFlowersAsync();
    }

    public Task<List<FertilizerModel>> GetAllFertilizersAsync()
    {
        return _repository.GetAllFertilizersAsync();
    }

    public Task<List<VaseModel>> GetAllVasesAsync()
    {
        return _repository.GetAllVasesAsync();
    }

    public async Task AddAsync(ProductModel product)
    {
        if (product.quantity < 0)
            throw new Exception("Quantidade não pode ser negativa."); //adicionar as regras de negocio aqui!!!

        await _repository.AddAsync(product);
    }

    public async Task UpdateAsync(ProductModel product)
    {
        if (product.quantity < 0)
            throw new Exception("Quantidade não pode ser negativa.");

        await _repository.UpdateAsync(product);
    }

    public async Task DeleteAsync(ProductModel product)
    {
        if (product == null)
            throw new Exception("Produto não pode ser nulo.");

        await _repository.DeleteAsync(product);
    }
}