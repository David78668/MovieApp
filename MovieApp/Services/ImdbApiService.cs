using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        // Function that searches for movies using the Download function
        public async Task<SearchData> Search(string input)
        {
            return await Download<SearchData>($"https://imdb-api.com/en/API/Search/k_4556bqwf/{input}");
        }

        // Function for downloading data from the API using HttpClient
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

    }
}
