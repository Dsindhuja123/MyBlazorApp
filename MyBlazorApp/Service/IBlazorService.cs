using RepositoryLayer.Models;
using ViewModels;

namespace MyBlazorApp.Service
{
    public interface IBlazorService
    {
        Task<List<ProductVM>> GetAll();
        Task<int> Add(ProductVM product);
    }
}
