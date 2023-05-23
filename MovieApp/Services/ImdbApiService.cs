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

        // Function that searches for titles using the Download function
        public async Task<ApiSearchData> Search(string input)
        {
            return await Download<ApiSearchData>($"https://imdb-api.com/en/API/Search/k_4556bqwf/{input}");
        }

		// Function that downloads for information about a specific title by Id
		public async Task<ApiTitleData.TitleResponse> GetMovie(string id)
		{
<<<<<<< HEAD
			return await Download<ApiTitleData.TitleResponse>($"https://imdb-api.com/en/API/Title/k_4556bqwf/{id}");
=======
			return await Download<TitleData.TitleResponse>($"https://imdb-api.com/en/API/Title/k_4556bqwf/{id}");
>>>>>>> a8ed6b4471308c552fab4e9b303e26967f16785c
		}

        // Function that downloads the top 250 movies
        public async Task<ApiTopMovies> GetTop250Movies()
        {
            return await Download<ApiTopMovies>("https://imdb-api.com/en/API/Top250Movies/k_4556bqwf");
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
