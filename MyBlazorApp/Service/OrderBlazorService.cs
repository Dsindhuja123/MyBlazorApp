using RepositoryLayer.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using ViewModels;
using static MudBlazor.CategoryTypes;
using RepositoryLayer;

namespace MyBlazorApp.Service
{
    public class OrderBlazorService : IOrderBlazorService
    {
        private readonly HttpClient _httpClient;

        public OrderBlazorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<OrderVM>> GetAll()
        {
            var orders = await _httpClient.GetFromJsonAsync<List<OrderVM>>("https://localhost:44384/api/orders/GetOrders");

            return orders;

        }

        public async Task<int> Add(OrderVM order)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:44384/api/orders/AddOrder", order);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<int>();
        }


        public async Task<OrderVM> GetOrderById(int productId)
        {
            var order = await _httpClient.GetFromJsonAsync<OrderVM>($"https://localhost:44384/api/orders/GetOrder/{productId}");
            return order;
        }




    }
}
