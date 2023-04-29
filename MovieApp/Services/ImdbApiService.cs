using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Models;

namespace MovieApp.Services
{
    public class ImdbApiService
    {
        private readonly HttpClient _client;
        private readonly ILogger<ImdbApiService> _logger;

        public ImdbApiService(ILogger<ImdbApiService> logger)
        {
            _client = new();
            _logger = logger;
        }

        private async Task<T?> Download<T>(string url)
        {
            try
            {
                return await _client.GetFromJsonAsync<T>(url);
            }
            catch (Exception ex)
            {
                _logger.LogError($"{url} - {ex.Message}");
            }
            return default(T?);
        }


        public async Task<IEnumerable<SearchResponse>> Search(string input)
        {
            return await Download<IEnumerable<SearchResponse>>($"https://imdb-api.com/API/Search/k_4556bqwf/{input}");
        }
    }
}
