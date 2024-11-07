

using Entities;
using Core.Interfaces;


namespace Bussines.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync(); // Tüm ürünleri al
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id); // ID'ye göre ürünü al
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product); // Yeni ürünü repository'e ekle
        }

        public async Task UpdateProductAsync(Product product)
        {
            await _productRepository.UpdateAsync(product); // Ürünü repository'de güncelle
        }

        public async Task DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id); // Ürünü repository'den sil
        }
    }
}
