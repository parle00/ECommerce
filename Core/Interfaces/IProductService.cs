using Entities;


namespace Core.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();    // Tüm ürünleri al
        Task<Product> GetProductByIdAsync(int id);    // ID'ye göre ürünü al
        Task AddProductAsync(Product product);         // Yeni ürünü ekle
        Task UpdateProductAsync(Product product);      // Ürünü güncelle
        Task DeleteProductAsync(int id);               // Ürünü sil
    }
}
