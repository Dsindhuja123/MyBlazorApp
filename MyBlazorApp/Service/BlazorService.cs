using RepositoryLayer.Models;
using System.Net.Http.Json;
using ViewModels;

namespace MyBlazorApp.Service
{
    public class BlazorService : IBlazorService
    {
        private readonly HttpClient _httpClient;

        public BlazorService(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }


        public async Task<List<ProductVM>> GetAll()
        {
            var products = await _httpClient.GetFromJsonAsync<List<ProductVM>>("https://localhost:44384/api/products/GetProducts");

            return products;
        }

        public async Task<int> Add(ProductVM product)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:44384/api/products/AddProduct", product);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }

    }
}
