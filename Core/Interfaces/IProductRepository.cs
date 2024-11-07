

using Entities;

namespace Core.Interfaces
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();        // Tüm ürünleri al
        Task<Product> GetByIdAsync(int id);       // ID'ye göre ürünü al
        Task AddAsync(Product product);            // Yeni ürünü ekle
        Task UpdateAsync(Product product);         // Ürünü güncelle
        Task DeleteAsync(int id);                  // Ürünü sil
    }

}
